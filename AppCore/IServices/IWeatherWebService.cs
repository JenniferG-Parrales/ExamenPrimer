using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.IServices
{
    public interface IWeatherWebService
    {

        Task<WeatherForeCast.ForeCastInfo> GetWeatherByGeo(double x, double y, long dt);
        Task<List<Coordenadas>> GetLatLong(string city);
    }
}
