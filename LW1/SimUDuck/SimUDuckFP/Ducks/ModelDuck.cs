using DancingDuckFP.Behaviors;
using System;
using System.Collections.Generic;
using System.Text;

namespace DancingDuckFP.Ducks
{
    class ModelDuck : CDuck
    {
        public ModelDuck() : base(FlyBehaviors.FlyNoWay,
                                 DanceBehaviors.NoDanceBehavior,
                                 QuackBehaviors.QuackBehavior)
        { }
        public override void Display()
        {
            Console.WriteLine("I'm a model duck!");
        }
    }
}
