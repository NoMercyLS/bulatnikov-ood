using Observer.Observer;
using Observer.WeatherData;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverTests
{
    public class UpdateObserverTest : Observer.Observer.IObserver<SWeatherInfo>
    {
        private readonly Observer.Observer.IObservable<SWeatherInfo> _observable;

        public UpdateObserverTest(Observer.Observer.IObservable<SWeatherInfo> observable)
        {
            _observable = observable;
        }

        public void Update(SWeatherInfo data)
        {
            _observable.RemoveObserver(this);
        }
    }
}
