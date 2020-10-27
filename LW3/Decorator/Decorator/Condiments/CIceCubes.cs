using Decorator.Beverages;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Condiments
{
    public class CIceCubes : CDecorator
    {
        public enum IceCubeType
        {
            Dry,
            Water
        }
        private readonly uint _quantity;
        private readonly IceCubeType _type;
        public CIceCubes(IBeverage beverage, uint quantity, IceCubeType type = IceCubeType.Water)
            : base(beverage)
        {
            _quantity = quantity;
            _type = type;
        }
        public override double GetCondimentCost()
        {
            return (_type == IceCubeType.Dry ? 10 : 5) * _quantity;
        }
        public override string GetCondimentDescription()
        {
            return (_type == IceCubeType.Dry ? "Dry" : "Water") + " ice cubes x" + _quantity.ToString();
        }
    }
}
