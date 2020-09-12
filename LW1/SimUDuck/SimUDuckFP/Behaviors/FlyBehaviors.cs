using System;
using System.Collections.Generic;
using System.Text;

namespace DancingDuckFP.Behaviors
{
    class FlyBehaviors
    {
        public static Action FlyWithWings()
        {
            int flightCount = 0;
            void Fly()
            {
                flightCount++;
                Console.WriteLine($"I'm flying with wings! Wow! It was my {flightCount} flight!!!");
            };
            return Fly;
        }
        public static void FlyNoWay()
        {
            Console.WriteLine("I don't fly...");
        }

    }
}
