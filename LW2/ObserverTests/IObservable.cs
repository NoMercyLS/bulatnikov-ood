﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Observer
{
    public interface IObservable<T>
    {
        void RegisterObserver(IObserver<T> observer, int priority);
        void RemoveObserver(IObserver<T> observer);
        void NotifyObservers();
    }
}
