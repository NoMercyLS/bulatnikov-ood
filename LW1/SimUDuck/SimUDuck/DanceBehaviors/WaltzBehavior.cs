using System;
using System.Collections.Generic;
using System.Text;

namespace DancingDuck.DanceBehaviors
{
    public class WaltzBehavior : IDanceBehavior
    {
        public void Dance()
        {
            Console.WriteLine("I'm dancing a waltz");
        }
    }
}
