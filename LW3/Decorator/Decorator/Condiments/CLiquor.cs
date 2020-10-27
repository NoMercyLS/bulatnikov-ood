using Decorator.Beverages;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Condiments
{
    public class CLiquor : CDecorator
    {
        public enum LiquorType
        {
            Nut,
            Chocolate
        }
        private readonly LiquorType _type;
        public CLiquor(IBeverage beverage, LiquorType type)
            : base(beverage)
        {
            _type = type;
        }
        public override double GetCondimentCost()
        {
            return 50;
        }
        public override string GetCondimentDescription()
        {
            return _type.ToString() + " Liquor";
        }
    }
}
