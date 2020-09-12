using DancingDuck.DanceBehaviors;
using DancingDuck.FlyBehaviors;
using DancingDuck.QuackBehaviors;
using System;
using System.Collections.Generic;
using System.Text;

namespace DancingDuck.Ducks
{
    class ModelDuck : CDuck
    {
        public ModelDuck() : base(new FlyNoWay(),
                                    new NoDanceBehavior(),
                                    new MutedBehavior())
        { }
        public override void Display()
        {
            Console.WriteLine("I'm a model duck!");
        }
    }
}
