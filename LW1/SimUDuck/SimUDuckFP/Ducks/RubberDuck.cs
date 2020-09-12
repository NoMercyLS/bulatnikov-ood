using DancingDuckFP.Behaviors;
using System;
using System.Collections.Generic;
using System.Text;

namespace DancingDuckFP.Ducks
{
    class RubberDuck : CDuck
    {
        public RubberDuck() : base(FlyBehaviors.FlyNoWay,
                                   DanceBehaviors.NoDanceBehavior,
                                   QuackBehaviors.SqeekBehavior)
        { }
        public override void Display()
        {
            Console.WriteLine("I'm a rubber duck!");
        }
    }
}
