using System;
using System.Collections.Generic;
using System.Text;

namespace DancingDuck.FlyBehaviors
{
    public class FlyWithWings : IFlyBehavior
    {
        private int flightCount = 0;
        public void Fly()
        {
            flightCount++;
            Console.WriteLine($"I'm flying with wings! Wow! It was my {flightCount} flight!!!");
        }
    }
}
