using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Beverages
{
    public class CCappucino : CBeverage
    {
        public enum CappucinoSize
        {
            Standart,
            Double
        }

        private readonly CappucinoSize _size;

        public CCappucino(CappucinoSize size = CappucinoSize.Standart) 
            : base(size.ToString() + " Cappucino")
        {
            _size = size;
        }

        public override double GetCost()
        {
            return _size == CappucinoSize.Standart ? 80 : 120;
        }
    }
}
