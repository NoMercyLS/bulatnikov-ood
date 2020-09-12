using System;
using System.Collections.Generic;
using System.Text;

namespace DancingDuck.QuackBehaviors
{
    public class SqeekBehavior : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Sqeek!");
        }
    }
}
