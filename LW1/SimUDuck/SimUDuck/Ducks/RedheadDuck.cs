using DancingDuck.DanceBehaviors;
using DancingDuck.FlyBehaviors;
using DancingDuck.QuackBehaviors;
using System;
using System.Collections.Generic;
using System.Text;

namespace DancingDuck.Ducks
{
    class RedheadDuck : CDuck
    {
        public RedheadDuck() : base (new FlyWithWings(), new MinuetBehavior(), new QuackBehavior())
        { }
        public override void Display()
        {
            Console.WriteLine("I'm a redhead duck!");
        }
    }
}
