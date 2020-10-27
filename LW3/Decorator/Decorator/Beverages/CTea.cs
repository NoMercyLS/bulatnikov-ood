using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Beverages
{
    public class CTea : CBeverage
    {
        public enum TeaType
        {
            DaHongPao,
            Tieguanyin,
            ShuiXian,
            Tieluohan
        }
        private readonly TeaType _type;
        public CTea(TeaType type = TeaType.Tieluohan) : base(type.ToString() + " Tea")
        {
            _type = type;
        }
        public override double GetCost()
        {
            return 30;
        }
    }
}
