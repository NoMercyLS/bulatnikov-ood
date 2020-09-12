using System;
using System.Collections.Generic;
using System.Text;

namespace DancingDuck.DanceBehaviors
{
    public class NoDanceBehavior : IDanceBehavior
    {
        public void Dance()
        {
            Console.WriteLine("I don't dance...");
        }
    }
}
