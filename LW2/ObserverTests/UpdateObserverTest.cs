using WeatherStation.Observer;
using WeatherStation.WeatherData;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverTests
{
    public class UpdateObserverTest : WeatherStation.Observer.IObserver<SWeatherInfo>
    {
        private readonly WeatherStation.Observer.IObservable<SWeatherInfo> _observable;

        public UpdateObserverTest(WeatherStation.Observer.IObservable<SWeatherInfo> observable)
        {
            _observable = observable;
        }

        public void Update(SWeatherInfo data)
        {
            _observable.RemoveObserver(this);
        }
    }
}
