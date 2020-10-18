using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherStationProDuo.Observer
{
    public interface IObserver<T>
    {
        void Update(T data, IObservable<T> observable);
    }
}
