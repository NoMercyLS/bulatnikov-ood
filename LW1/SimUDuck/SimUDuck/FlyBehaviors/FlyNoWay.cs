using System;
using System.Collections.Generic;
using System.Text;

namespace DancingDuck.FlyBehaviors
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I don't fly...");
        }
    }
}
