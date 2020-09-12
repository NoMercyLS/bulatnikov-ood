using DancingDuck.DanceBehaviors;
using DancingDuck.FlyBehaviors;
using DancingDuck.QuackBehaviors;
using System;
using System.Collections.Generic;
using System.Text;

namespace DancingDuck.Ducks
{
    class CDuck
    {
        private IFlyBehavior FlyBehavior { get; set; }
        private IDanceBehavior DanceBehavior { get; set; }
        private IQuackBehavior QuackBehavior { get; set; }
        public CDuck(IFlyBehavior _flyBehavior, IDanceBehavior _danceBehavior, IQuackBehavior _quackBehavior)
        {
            FlyBehavior = _flyBehavior;
            DanceBehavior = _danceBehavior;
            QuackBehavior = _quackBehavior;
        }
        public void Fly()
        {
            FlyBehavior.Fly();
        }

        public void Dance()
        {
            DanceBehavior.Dance();
        }

        public void Quack()
        {
            QuackBehavior.Quack();
        }

        public void SetFlyBehavior(IFlyBehavior _newFlyBehavior)
        {
            FlyBehavior = _newFlyBehavior;
        }

        public virtual void Display() { }
    }
}
