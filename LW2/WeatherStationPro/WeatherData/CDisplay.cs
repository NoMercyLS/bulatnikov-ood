using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherStationPro.WeatherData
{
    public class CDisplay : Observer.IObserver<SWeatherInfo>
    {
        public void Update(SWeatherInfo data)
        {
            Console.WriteLine("Current measurements:");
            Console.WriteLine($"Temperature: {data.temperature}");
            Console.WriteLine($"Humidity: {data.humidity}");
            Console.WriteLine($"Pressure: {data.pressure}");
            Console.WriteLine($"Wind speed: {data.wind.speed}");
            Console.WriteLine($"Wind direction: {data.wind.direction}");
            Console.WriteLine();
        }

    }
}
