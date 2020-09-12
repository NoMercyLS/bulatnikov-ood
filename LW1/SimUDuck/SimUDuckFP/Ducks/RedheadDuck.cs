using DancingDuckFP.Behaviors;
using System;
using System.Collections.Generic;
using System.Text;

namespace DancingDuckFP.Ducks
{
    class RedheadDuck : CDuck
    {
        public RedheadDuck() : base (FlyBehaviors.FlyWithWings(),
                                    DanceBehaviors.MinuetBehavior,
                                    QuackBehaviors.QuackBehavior)
        { }
        public override void Display()
        {
            Console.WriteLine("I'm a redhead duck!");
        }
    }
}
