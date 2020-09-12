using System;
using System.Collections.Generic;
using System.Text;

namespace DancingDuck.QuackBehaviors
{
    public class QuackBehavior : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack!");
        }
    }
}
