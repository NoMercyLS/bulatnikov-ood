using Decorator.Beverages;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Condiments
{
    public class CChocolate : CDecorator
    {
        private readonly uint _count;
        public CChocolate(IBeverage beverage, uint count) : base(beverage)
        {
            _count = count > 5 ? 5 : count;
        }
        public override double GetCondimentCost()
        {
            return 10.0 * _count;
        }
        public override string GetCondimentDescription()
        {
            return "Chocolate " + _count.ToString() + " pieces";
        }
    }
}
