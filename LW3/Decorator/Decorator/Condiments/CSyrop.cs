using Decorator.Beverages;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Condiments
{
    public class CSyrop : CDecorator
    {
        public enum SyropType
        {
            Chocolate,
            Maple
        }
        private readonly SyropType _syropType;
        public CSyrop(IBeverage beverage, SyropType syrupType)
            : base(beverage)
        {
            _syropType = syrupType;
        }
        public override double GetCondimentCost()
        {
            return 15;
        }
        public override string GetCondimentDescription()
        {
            return (_syropType == SyropType.Chocolate ? "Chocolate" : "Maple") + " syrup";
        }
    }
}
