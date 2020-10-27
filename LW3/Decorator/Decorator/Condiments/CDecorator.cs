using Decorator.Beverages;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Condiments
{
    public abstract class CDecorator : IBeverage
    {
        private readonly IBeverage _beverage;
        protected CDecorator(IBeverage beverage)
        {
            _beverage = beverage;
        }
        public double GetCost()
        {
            return _beverage.GetCost() + GetCondimentCost();
        }
        public string GetDescription()
        {
            return _beverage.GetDescription() + ", " + GetCondimentDescription();
        }
        public abstract double GetCondimentCost();
        public abstract string GetCondimentDescription();
    }
}
