using AppCore.IServices;
using AppCore.Services;
using Common;
using Domain.Entities;
using Infraestructure.OpenWeatherClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenWeather
{
    public partial class Form1 : Form
    {
        string ciudad;
        double x, y;
        long dt;
        //public OpenWeather openWeather;
        public WeatherForeCast.ForeCastInfo wfc;
        public IWeatherWebService opw;
        public List <coordenadas> cd;
        public IweatherServices weatherServices;
        public Form1(IweatherServices WeatherServices, IWeatherWebService opw)
        {
            this.weatherServices = WeatherServices;
            this.opw = opw;
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                ciudad = cmbCity.SelectedItem.ToString();
                flpContent.Controls.Clear();
                Task.Run(Request).Wait();

                x = cd[0].lat;
                y = cd[0].lon;
                Task.Run(Request2).Wait();
                if (wfc == null)
                {
                    throw new NullReferenceException("Fallo al obtener el objeto OpenWeather.");
                }
                double temp = wfc.current.temp - 273.15;
                DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
                DateTime day1 = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
                lbl2Ciudad.Text = ciudad;
                lbl4teemp.Text = (int)temp + "C";
                lbl1Details.Text = wfc.current.weather[0].description;
                day = day.AddSeconds(wfc.current.sunrise).ToLocalTime();
                label6Sunrise.Text = day.ToShortTimeString();
                day1 = day1.AddSeconds(wfc.current.sunset).ToLocalTime();
                label5Sunset.Text = day1.ToShortTimeString();
                label1WS.Text = wfc.current.wind_speed.ToString() + " Km/h";
                label2Pressure.Text = wfc.current.pressure.ToString();
                label3Humm.Text = wfc.current.humidity.ToString() + "%";
                label4Visb.Text = wfc.current.visibility.ToString();
                lbl3Weather.Text = wfc.current.weather[0].main;
                WeatherIcon.ImageLocation = $"{AppSettings.ApiIcon}" + wfc.current.weather[0].icon + ".png";
                MiniDetail mini;
                for (int i = 0; i < 5; i++)
                {
                    ciudad = cmbCity.SelectedItem.ToString();
                    //DateTimeOffset dateTimeOffset = DateTime.Now.AddDays(-i-1);
                    dt = DateTimeOffset.Now.ToUnixTimeSeconds();
                    Task.Run(Request).Wait();

                    x = cd[0].lat;
                    y = cd[0].lon;
                    Task.Run(Request2).Wait();
                    if (wfc == null)
                    {
                        throw new NullReferenceException("Fallo al obtener el objeto OpenWeather.");
                    }
                    weatherServices.Add(wfc);
                    double lbl4teemp = wfc.current.temp - 273.15;
                    WeatherPanel weatherPanel = new WeatherPanel(weatherServices, opw);
                    weatherPanel.x = x;
                    weatherPanel.y = y;
                    weatherPanel.lblCity.Text = ciudad;
                    weatherPanel.lblTemp.Text = (int)temp + "C";
                    weatherPanel.lblWeather.Text = wfc.current.weather[0].main;
                    weatherPanel.WeatherIcon.ImageLocation = $"{AppSettings.ApiIcon}" + wfc.current.weather[0].icon + ".png";
                    flpContent.Controls.Add(weatherPanel);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        
        DateTime ConvertDateTime(long Milisec)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).ToLocalTime();

            day = day.AddSeconds(Milisec).ToLocalTime();

            return day;
        }
      

        public async Task Request()
        {
            cd = await opw.GetLatLong(ciudad);
        }
        public async Task Request2()
        {
            wfc = await opw.GetWeatherByGeo(x,y,dt);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string json = Encoding.UTF8.GetString(Properties.Resources.NicaraguaCitys);
            List<Citys> Ciudades = new List<Citys>();
            Ciudades = JsonConvert.DeserializeObject<List<Citys>>(json);
            cmbCity.DataSource = Ciudades.Select(x => x.City).ToList();
        }
    }
    }

