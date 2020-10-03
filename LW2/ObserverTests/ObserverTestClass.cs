using Microsoft.VisualStudio.TestTools.UnitTesting;
using Observer.Observer;
using Observer.WeatherData;
using System;

namespace ObserverTests
{
    public class ObserverTestClass : Observer.Observer.IObserver<SWeatherInfo>
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
