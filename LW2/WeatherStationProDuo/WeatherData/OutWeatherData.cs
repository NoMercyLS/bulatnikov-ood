using System;
using System.Collections.Generic;
using System.Text;
using WeatherStationProDuo.Observer;

namespace WeatherStationProDuo.WeatherData
{
    public class OutWeatherData : CObservable<SWeatherInfo>
    {
        private double _temperature = 0.0;
        private double _humidity = 0.0;
        private double _pressure = 760.0;
        private double _speed = 0;
        private double _direction = 0;
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
        public double GetSpeed()
        {
            return _speed;
        }
        public double GetDirection()
        {
            return _direction;
        }
        public void MeasurementChanged()
        {
            NotifyObservers();
        }
        public void SetMeasurements(double temperature, double humidity, double pressure, double speed, double direction)
        {
            if (_humidity != humidity ||
                _temperature != temperature ||
                _pressure != pressure ||
                _speed != speed ||
                _direction != direction)
            {
                _temperature = temperature;
                _humidity = humidity;
                _pressure = pressure;
                _speed = speed;
                _direction = direction;
                MeasurementChanged();
            }
        }
        protected override SWeatherInfo GetChangedData()
        {
            SWeatherInfo info;
            info.temperature = GetTemperature();
            info.pressure = GetPressure();
            info.humidity = GetHumidity();
            info.wind = new SWindInfo()
            {
                speed = GetSpeed(),
                direction = GetDirection()
            };
            return info;
        }
    }
}
