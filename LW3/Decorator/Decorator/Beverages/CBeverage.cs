using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Beverages
{
    public abstract class CBeverage : IBeverage
    {
        private readonly string _description = "";
        public CBeverage(string description) { _description = description; }
        public abstract double GetCost();
        public string GetDescription() { return _description; }
    }
}
