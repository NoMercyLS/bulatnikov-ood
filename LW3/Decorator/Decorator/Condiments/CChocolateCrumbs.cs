using Decorator.Beverages;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Condiments
{
    public class CChocolateCrumbs : CDecorator
    {
        private readonly uint _mass;
        public CChocolateCrumbs(IBeverage beverage, uint mass) : base(beverage)
        {
            _mass = mass;
        }
        public override double GetCondimentCost()
        {
            return 2.0 * _mass;
        }
        public override string GetCondimentDescription()
        {
            return "Chocolate crumbs " + _mass.ToString() + "g";
        }
    }
}
