using DancingDuck.DanceBehaviors;
using DancingDuck.FlyBehaviors;
using DancingDuck.QuackBehaviors;
using System;
using System.Collections.Generic;
using System.Text;

namespace DancingDuck.Ducks
{
    class MallardDuck : CDuck
    {
        public MallardDuck() : base(new FlyWithWings(),
                                    new WaltzBehavior(), 
                                    new QuackBehavior())
        { }
        public override void Display()
        {
            Console.WriteLine("I'm a mallard duck!");
        }
    }
}
