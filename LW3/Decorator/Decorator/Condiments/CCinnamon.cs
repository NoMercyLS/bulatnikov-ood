using Decorator.Beverages;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Condiments
{
    public class CCinnamon : CDecorator
    {
        public CCinnamon(IBeverage beverage) : base(beverage) { }
        public override double GetCondimentCost()
        {
            return 20;
        }
        public override string GetCondimentDescription()
        {
            return "Cinnamon";
        }
    }
}
