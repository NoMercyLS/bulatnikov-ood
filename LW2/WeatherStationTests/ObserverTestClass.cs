using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeatherStation.Observer;
using WeatherStation.WeatherData;
using System;

namespace ObserverTests
{
    public class ObserverTestClass : WeatherStation.Observer.IObserver<SWeatherInfo>
    {
        private readonly int _priority;
        public ObserverTestClass(int priority)
        {
            _priority = priority;
        }

        public void Update(SWeatherInfo data)
        {
            Console.Write($"{_priority};");
        }
    }
}
