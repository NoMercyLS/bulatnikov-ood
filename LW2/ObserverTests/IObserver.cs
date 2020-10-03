using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Observer
{
    public interface IObserver<T>
    {
        void Update(T data);
    }
}
