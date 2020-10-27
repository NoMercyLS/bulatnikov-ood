using Decorator.Beverages;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Condiments
{
    public class CCoconutFlakes : CDecorator
    {
        private readonly uint _mass;
        public CCoconutFlakes(IBeverage beverage, uint mass) : base(beverage)
        {
            _mass = mass;
        }
        public override double GetCondimentCost()
        {
            return 1.0 * _mass;
        }
        public override string GetCondimentDescription()
        {
            return "Coconut flakes " + _mass.ToString() + "g";
        }
    }
}
