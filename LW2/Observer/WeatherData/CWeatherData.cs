using WeatherStation.Observer;
using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherStation.WeatherData
{
    public class CWeatherData : CObservable<SWeatherInfo>
    {
        private double _temperature = 0.0;
        private double _humidity = 0.0;
        private double _pressure = 760.0;
        public double GetTemperature()
        {
            return _temperature;
        }
        public double GetHumidity()
        {
            return _humidity;
        }
        public double GetPressure()
        {
            return _pressure;
        }
        public void MeasurementChanged()
        {
            NotifyObservers();
        }
        public void SetMeasurements(double temperature, double humidity, double pressure)
        {
            if (_humidity != humidity || _temperature != temperature || _pressure != pressure)
            {
                _temperature = temperature;
                _humidity = humidity;
                _pressure = pressure;

                MeasurementChanged();
            }
        }
        protected override SWeatherInfo GetChangedData()
        {
            SWeatherInfo info;
            info.temperature = GetTemperature();
            info.pressure = GetPressure();
            info.humidity = GetHumidity();
            return info;
        }
    }
}
