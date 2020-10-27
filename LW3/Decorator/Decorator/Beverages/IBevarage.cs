using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Beverages
{
    public interface IBeverage
    {
        public string GetDescription();
        public double GetCost();
    }
}
