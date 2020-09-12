using DancingDuckFP.Behaviors;
using System;
using System.Collections.Generic;
using System.Text;

namespace DancingDuckFP.Ducks
{
    class MallardDuck : CDuck
    {
        public MallardDuck() : base(FlyBehaviors.FlyWithWings(),
                                    DanceBehaviors.WaltzBehavior,
                                    QuackBehaviors.QuackBehavior)
        { }
        public override void Display()
        {
            Console.WriteLine("I'm a mallard duck!");
        }
    }
}
