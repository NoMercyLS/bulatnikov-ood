using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Beverages
{
    public class CLatte : CBeverage
    {
        public enum LatteSize
        {
            Standart,
            Double
        }
        private readonly LatteSize _size;

        public CLatte(LatteSize size = LatteSize.Standart) : base(size.ToString() + " Latte")
        {
            _size = size;
        }
        public override double GetCost()
        {
            return _size == LatteSize.Standart ? 90 : 130;
        }
    }
}
