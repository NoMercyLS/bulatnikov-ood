using System;
using System.Collections.Generic;
using System.Text;
using WeatherStationProDuo.Observer;

namespace WeatherStationProDuo.WeatherData
{
    public class CDisplay : Observer.IObserver<SWeatherInfo>
    {
        private readonly InWeatherData _inWeatherData = new InWeatherData();
        private readonly OutWeatherData _outWeatherData = new OutWeatherData();
        public CDisplay(InWeatherData inWeatherData, OutWeatherData outWeatherData)
        {
            _inWeatherData = inWeatherData;
            _outWeatherData = outWeatherData;
        }
        public void Update(SWeatherInfo data, Observer.IObservable<SWeatherInfo> observable)
        {
            if (observable == _inWeatherData)
            {
                Console.WriteLine("Inside:");
            }
            if (observable == _outWeatherData)
            {
                Console.WriteLine("Outside:");
                Console.WriteLine($"Wind speed: {data.wind.Value.speed}");
                Console.WriteLine($"Wind direction: {data.wind.Value.direction}");
            }
            Console.WriteLine($"Temperature: {data.temperature}");
            Console.WriteLine($"Humidity: {data.humidity}");
            Console.WriteLine($"Pressure: {data.pressure}");
            Console.WriteLine();
        }

    }
}
