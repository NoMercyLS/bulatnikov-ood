using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherStationPro.Observer
{
    public interface IObserver<T>
    {
        void Update(T data);
    }
}
