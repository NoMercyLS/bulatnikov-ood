using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherStation.Observer
{
    public interface IObserver<T>
    {
        void Update(T data);
    }
}
