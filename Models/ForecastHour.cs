using System;

namespace BlueShorts
{
    public class ForecastHour
    {
        public float TempC { get; set; }
        public float TempF { get; set; }
        public float WindMph { get; set; }
        public float WindKph { get; set; }
        public int WindDegree { get; set; }
        public string WindDir { get; set; }
        public int Humidity { get; set; }
        public float Uv { get; set; }
        public int ChanceOfRain { get; set; }
        public DateTime Time { get; set; }
    }
}