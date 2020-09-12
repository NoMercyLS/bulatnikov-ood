using DancingDuck.DanceBehaviors;
using DancingDuck.FlyBehaviors;
using DancingDuck.QuackBehaviors;
using System;
using System.Collections.Generic;
using System.Text;

namespace DancingDuck.Ducks
{
    class RubberDuck : CDuck
    {
        public RubberDuck() : base(new FlyNoWay(),
                                    new NoDanceBehavior(),
                                    new SqeekBehavior())
        { }
        public override void Display()
        {
            Console.WriteLine("I'm a rubber duck!");
        }
    }
}
