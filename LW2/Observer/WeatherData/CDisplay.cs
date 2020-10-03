using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.WeatherData
{
    public class CDisplay : Observer.IObserver<SWeatherInfo>
    {
        public void Update(SWeatherInfo data)
        {
            Console.WriteLine("Current measurements:");
            Console.WriteLine($"Temperature: {data.temperature}");
            Console.WriteLine($"Humidity: {data.humidity}");
            Console.WriteLine($"Pressure: {data.pressure}");
            Console.WriteLine();
        }
        
    }
}
