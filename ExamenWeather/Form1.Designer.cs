namespace ExamenWeather
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.flpContent = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDetails = new System.Windows.Forms.Label();
            this.label1WS = new System.Windows.Forms.Label();
            this.lblWindSpeed = new System.Windows.Forms.Label();
            this.label3Humm = new System.Windows.Forms.Label();
            this.lblPressure = new System.Windows.Forms.Label();
            this.label5Sunset = new System.Windows.Forms.Label();
            this.lblHummidity = new System.Windows.Forms.Label();
            this.label4Visb = new System.Windows.Forms.Label();
            this.label2Pressure = new System.Windows.Forms.Label();
            this.lblVisibility = new System.Windows.Forms.Label();
            this.label6Sunrise = new System.Windows.Forms.Label();
            this.lblSunset = new System.Windows.Forms.Label();
            this.lblSunrise = new System.Windows.Forms.Label();
            this.WeatherIcon = new System.Windows.Forms.PictureBox();
            this.lbl1Details = new System.Windows.Forms.Label();
            this.lbl2Ciudad = new System.Windows.Forms.Label();
            this.lbl3Weather = new System.Windows.Forms.Label();
            this.lbl4teemp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WeatherIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(637, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // cmbCity
            // 
            this.cmbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(362, 47);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(187, 21);
            this.cmbCity.TabIndex = 1;
            // 
            // flpContent
            // 
            this.flpContent.AutoScroll = true;
            this.flpContent.Location = new System.Drawing.Point(12, 387);
            this.flpContent.Name = "flpContent";
            this.flpContent.Size = new System.Drawing.Size(700, 250);
            this.flpContent.TabIndex = 0;
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Colonna MT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.Location = new System.Drawing.Point(12, 204);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(88, 25);
            this.lblDetails.TabIndex = 0;
            this.lblDetails.Text = "Details";
            // 
            // label1WS
            // 
            this.label1WS.AutoSize = true;
            this.label1WS.Font = new System.Drawing.Font("Colonna MT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1WS.Location = new System.Drawing.Point(174, 253);
            this.label1WS.Name = "label1WS";
            this.label1WS.Size = new System.Drawing.Size(62, 25);
            this.label1WS.TabIndex = 1;
            this.label1WS.Text = "N/A";
            // 
            // lblWindSpeed
            // 
            this.lblWindSpeed.AutoSize = true;
            this.lblWindSpeed.Font = new System.Drawing.Font("Colonna MT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindSpeed.Location = new System.Drawing.Point(7, 247);
            this.lblWindSpeed.Name = "lblWindSpeed";
            this.lblWindSpeed.Size = new System.Drawing.Size(140, 25);
            this.lblWindSpeed.TabIndex = 2;
            this.lblWindSpeed.Text = "Wind Speed";
            // 
            // label3Humm
            // 
            this.label3Humm.AutoSize = true;
            this.label3Humm.Font = new System.Drawing.Font("Colonna MT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3Humm.Location = new System.Drawing.Point(163, 340);
            this.label3Humm.Name = "label3Humm";
            this.label3Humm.Size = new System.Drawing.Size(62, 25);
            this.label3Humm.TabIndex = 3;
            this.label3Humm.Text = "N/A";
            // 
            // lblPressure
            // 
            this.lblPressure.AutoSize = true;
            this.lblPressure.Font = new System.Drawing.Font("Colonna MT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPressure.Location = new System.Drawing.Point(12, 293);
            this.lblPressure.Name = "lblPressure";
            this.lblPressure.Size = new System.Drawing.Size(107, 25);
            this.lblPressure.TabIndex = 4;
            this.lblPressure.Text = "Pressure";
            // 
            // label5Sunset
            // 
            this.label5Sunset.AutoSize = true;
            this.label5Sunset.Font = new System.Drawing.Font("Colonna MT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5Sunset.Location = new System.Drawing.Point(482, 259);
            this.label5Sunset.Name = "label5Sunset";
            this.label5Sunset.Size = new System.Drawing.Size(62, 25);
            this.label5Sunset.TabIndex = 5;
            this.label5Sunset.Text = "N/A";
            // 
            // lblHummidity
            // 
            this.lblHummidity.AutoSize = true;
            this.lblHummidity.Font = new System.Drawing.Font("Colonna MT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHummidity.Location = new System.Drawing.Point(7, 334);
            this.lblHummidity.Name = "lblHummidity";
            this.lblHummidity.Size = new System.Drawing.Size(139, 25);
            this.lblHummidity.TabIndex = 6;
            this.lblHummidity.Text = "Hummidity";
            // 
            // label4Visb
            // 
            this.label4Visb.AutoSize = true;
            this.label4Visb.Font = new System.Drawing.Font("Colonna MT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4Visb.Location = new System.Drawing.Point(482, 216);
            this.label4Visb.Name = "label4Visb";
            this.label4Visb.Size = new System.Drawing.Size(62, 25);
            this.label4Visb.TabIndex = 2;
            this.label4Visb.Text = "N/A";
            // 
            // label2Pressure
            // 
            this.label2Pressure.AutoSize = true;
            this.label2Pressure.Font = new System.Drawing.Font("Colonna MT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2Pressure.Location = new System.Drawing.Point(143, 305);
            this.label2Pressure.Name = "label2Pressure";
            this.label2Pressure.Size = new System.Drawing.Size(62, 25);
            this.label2Pressure.TabIndex = 8;
            this.label2Pressure.Text = "N/A";
            // 
            // lblVisibility
            // 
            this.lblVisibility.AutoSize = true;
            this.lblVisibility.Font = new System.Drawing.Font("Colonna MT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisibility.Location = new System.Drawing.Point(340, 210);
            this.lblVisibility.Name = "lblVisibility";
            this.lblVisibility.Size = new System.Drawing.Size(116, 25);
            this.lblVisibility.TabIndex = 9;
            this.lblVisibility.Text = "Visibility";
            // 
            // label6Sunrise
            // 
            this.label6Sunrise.AutoSize = true;
            this.label6Sunrise.Font = new System.Drawing.Font("Colonna MT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6Sunrise.Location = new System.Drawing.Point(470, 305);
            this.label6Sunrise.Name = "label6Sunrise";
            this.label6Sunrise.Size = new System.Drawing.Size(62, 25);
            this.label6Sunrise.TabIndex = 10;
            this.label6Sunrise.Text = "N/A";
            // 
            // lblSunset
            // 
            this.lblSunset.AutoSize = true;
            this.lblSunset.Font = new System.Drawing.Font("Colonna MT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSunset.Location = new System.Drawing.Point(340, 253);
            this.lblSunset.Name = "lblSunset";
            this.lblSunset.Size = new System.Drawing.Size(84, 25);
            this.lblSunset.TabIndex = 11;
            this.lblSunset.Text = "Sunset";
            // 
            // lblSunrise
            // 
            this.lblSunrise.AutoSize = true;
            this.lblSunrise.Font = new System.Drawing.Font("Colonna MT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSunrise.Location = new System.Drawing.Point(340, 293);
            this.lblSunrise.Name = "lblSunrise";
            this.lblSunrise.Size = new System.Drawing.Size(93, 25);
            this.lblSunrise.TabIndex = 12;
            this.lblSunrise.Text = "Sunrise";
            // 
            // WeatherIcon
            // 
            this.WeatherIcon.Location = new System.Drawing.Point(56, 80);
            this.WeatherIcon.Name = "WeatherIcon";
            this.WeatherIcon.Size = new System.Drawing.Size(100, 50);
            this.WeatherIcon.TabIndex = 13;
            this.WeatherIcon.TabStop = false;
            // 
            // lbl1Details
            // 
            this.lbl1Details.AutoSize = true;
            this.lbl1Details.Location = new System.Drawing.Point(121, 210);
            this.lbl1Details.Name = "lbl1Details";
            this.lbl1Details.Size = new System.Drawing.Size(0, 13);
            this.lbl1Details.TabIndex = 14;
            // 
            // lbl2Ciudad
            // 
            this.lbl2Ciudad.AutoSize = true;
            this.lbl2Ciudad.Location = new System.Drawing.Point(14, 19);
            this.lbl2Ciudad.Name = "lbl2Ciudad";
            this.lbl2Ciudad.Size = new System.Drawing.Size(0, 13);
            this.lbl2Ciudad.TabIndex = 15;
            // 
            // lbl3Weather
            // 
            this.lbl3Weather.AutoSize = true;
            this.lbl3Weather.Location = new System.Drawing.Point(205, 105);
            this.lbl3Weather.Name = "lbl3Weather";
            this.lbl3Weather.Size = new System.Drawing.Size(0, 13);
            this.lbl3Weather.TabIndex = 16;
            // 
            // lbl4teemp
            // 
            this.lbl4teemp.AutoSize = true;
            this.lbl4teemp.Location = new System.Drawing.Point(53, 160);
            this.lbl4teemp.Name = "lbl4teemp";
            this.lbl4teemp.Size = new System.Drawing.Size(0, 13);
            this.lbl4teemp.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 649);
            this.Controls.Add(this.lbl4teemp);
            this.Controls.Add(this.lbl3Weather);
            this.Controls.Add(this.lbl2Ciudad);
            this.Controls.Add(this.lbl1Details);
            this.Controls.Add(this.WeatherIcon);
            this.Controls.Add(this.lblSunrise);
            this.Controls.Add(this.lblSunset);
            this.Controls.Add(this.label6Sunrise);
            this.Controls.Add(this.lblVisibility);
            this.Controls.Add(this.label2Pressure);
            this.Controls.Add(this.lblHummidity);
            this.Controls.Add(this.label5Sunset);
            this.Controls.Add(this.lblPressure);
            this.Controls.Add(this.label3Humm);
            this.Controls.Add(this.lblWindSpeed);
            this.Controls.Add(this.label1WS);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.label4Visb);
            this.Controls.Add(this.flpContent);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WeatherIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.FlowLayoutPanel flpContent;
        private System.Windows.Forms.Label lblWindSpeed;
        private System.Windows.Forms.Label label3Humm;
        private System.Windows.Forms.Label lblPressure;
        private System.Windows.Forms.Label label5Sunset;
        private System.Windows.Forms.Label lblHummidity;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label label1WS;
        private System.Windows.Forms.Label label4Visb;
        private System.Windows.Forms.Label label2Pressure;
        private System.Windows.Forms.Label lblVisibility;
        private System.Windows.Forms.Label label6Sunrise;
        private System.Windows.Forms.Label lblSunset;
        private System.Windows.Forms.Label lblSunrise;
        public System.Windows.Forms.PictureBox WeatherIcon;
        private System.Windows.Forms.Label lbl1Details;
        private System.Windows.Forms.Label lbl2Ciudad;
        private System.Windows.Forms.Label lbl3Weather;
        private System.Windows.Forms.Label lbl4teemp;
    }
}

