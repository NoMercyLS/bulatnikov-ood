using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherStationProDuo.WeatherData
{
    public struct SWeatherInfo
    {
        public double temperature;
        public double humidity;
        public double pressure;
        public SWindInfo? wind;
    }
}
