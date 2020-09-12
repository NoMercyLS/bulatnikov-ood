using DancingDuck.DanceBehaviors;
using DancingDuck.FlyBehaviors;
using DancingDuck.QuackBehaviors;
using System;
using System.Collections.Generic;
using System.Text;

namespace DancingDuck.Ducks
{
    class DecoyDuck : CDuck
    {
        public DecoyDuck() : base(new FlyNoWay(),
                                  new NoDanceBehavior(),
                                  new MutedBehavior())
        { }
        public override void  Display()
        {
            Console.WriteLine("I'm a decoy duck");
        }
    }
}
