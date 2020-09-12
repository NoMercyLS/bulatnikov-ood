using System;

namespace DancingDuckFP.Ducks
{
    class CDuck
    {
        private Action FlyBehavior { get; set; }
        private Action DanceBehavior { get; set; }
        private Action QuackBehavior { get; set; }
        public CDuck(Action _flyBehavior, Action _danceBehavior, Action _quackBehavior)
        {
            FlyBehavior = _flyBehavior;
            DanceBehavior = _danceBehavior;
            QuackBehavior = _quackBehavior;
        }
        public void Fly()
        {
            FlyBehavior();
        }

        public void Dance()
        {
            DanceBehavior();
        }

        public void Quack()
        {
            QuackBehavior();
        }

        public void SetFlyBehavior(Action _newFlyBehavior)
        {
            FlyBehavior = _newFlyBehavior;
        }

        public virtual void Display() { }
    }
}
