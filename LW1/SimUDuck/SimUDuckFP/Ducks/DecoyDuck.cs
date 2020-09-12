using DancingDuckFP.Behaviors;
using System;

namespace DancingDuckFP.Ducks
{
    class DecoyDuck : CDuck
    {
        public DecoyDuck() : base(FlyBehaviors.FlyNoWay,
                                  DanceBehaviors.NoDanceBehavior,
                                  QuackBehaviors.MutedBehavior)
        { }
        public override void  Display()
        {
            Console.WriteLine("I'm a decoy duck");
        }
    }
}
