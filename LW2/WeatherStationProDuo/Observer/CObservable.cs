using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeatherStationProDuo.Observer
{
    public abstract class CObservable<T> : IObservable<T>
    {
        private List<(IObserver<T>, int)> _observers = new List<(IObserver<T>, int)>();

        public void RegisterObserver(IObserver<T> observer, int priority)
        {
            _observers.Add((observer, priority));
            _observers = _observers.OrderByDescending(obj => obj.Item2).ToList();
        }

        public void RemoveObserver(IObserver<T> observer)
        {
            _observers.RemoveAll(obj => obj.Item1.Equals(observer));
        }

        public void NotifyObservers()
        {
            T data = GetChangedData();
            foreach (var obs in _observers.ToList())
            {
                obs.Item1.Update(data, this);
            }
        }

        protected abstract T GetChangedData();
    }
}
