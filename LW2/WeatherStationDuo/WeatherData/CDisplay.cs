using System;
using System.Collections.Generic;
using System.Text;
using WeatherStationDuo.Observer;

namespace WeatherStationDuo.WeatherData
{
    public class CDisplay : Observer.IObserver<SWeatherInfo>
    {
        private readonly CWeatherData _insideWeatherData;
        private readonly CWeatherData _outsideWeatherData;
        public CDisplay(CWeatherData insideWeatherData, CWeatherData outsideWeatherData)
        {
            _insideWeatherData = insideWeatherData;
            _outsideWeatherData = outsideWeatherData;
        }
        public void Update(SWeatherInfo data, Observer.IObservable<SWeatherInfo> observable)
        {
            if (_insideWeatherData == observable)
            {
                Console.Write("Inside data. ");
            }
            if (_outsideWeatherData == observable)
            {
                Console.Write("Outside data. ");
            }
            Console.WriteLine("Current measurements:");
            Console.WriteLine($"Temperature: {data.temperature}");
            Console.WriteLine($"Humidity: {data.humidity}");
            Console.WriteLine($"Pressure: {data.pressure}");
            Console.WriteLine();
        }
        
    }
}
