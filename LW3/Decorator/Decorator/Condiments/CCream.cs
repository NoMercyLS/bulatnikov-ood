using Decorator.Beverages;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Condiments
{
    public class CCream : CDecorator
    {
        public CCream(IBeverage beverage)
            : base(beverage)
        {
        }
        public override double GetCondimentCost()
        {
            return 25;
        }
        public override string GetCondimentDescription()
        {
            return "Cream";
        }
    }
}
