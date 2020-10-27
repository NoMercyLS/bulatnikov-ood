using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Beverages
{
    public class CMilkShake : CBeverage
    {
        public enum MilkshakeSize
        {
            Small,
            Medium,
            Large
        }
        private readonly MilkshakeSize _size;
        public CMilkShake(MilkshakeSize size = MilkshakeSize.Small) : base(size.ToString() + " Milkshake")
        {
            _size = size;
        }
        public override double GetCost()
        {
            return _size switch
            {
                MilkshakeSize.Small => 50,
                MilkshakeSize.Medium => 60,
                MilkshakeSize.Large => 80,
                _ => 0
            };
        }
    }
}
