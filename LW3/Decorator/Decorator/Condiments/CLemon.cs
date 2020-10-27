using Decorator.Beverages;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Condiments
{
    public class CLemon : CDecorator
    {
        private readonly uint _quantity;
        public CLemon(IBeverage beverage, uint quantity)
           : base(beverage)
        {
            _quantity = quantity;
        }
        public override double GetCondimentCost()
        {
            return 10.0 * _quantity;
        }
        public override string GetCondimentDescription()
        {
            return "Lemon x" + _quantity.ToString();
        }
    }
}
