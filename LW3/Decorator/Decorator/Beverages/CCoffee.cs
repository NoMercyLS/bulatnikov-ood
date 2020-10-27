using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Beverages
{
    public class CCoffee : CBeverage
    {
        public CCoffee(string description = "Coffee")
            : base(description) 
        { }
        public override double GetCost() { return 60; }
    }
}
