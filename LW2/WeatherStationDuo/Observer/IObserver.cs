using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherStationDuo.Observer
{
    public interface IObserver<T>
    {
        void Update(T data, IObservable<T> observable);
    }
}
