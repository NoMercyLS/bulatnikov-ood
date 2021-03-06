﻿using DancingDuckFP.Behaviors;
using DancingDuckFP.Ducks;
using System;

namespace DancingDuckFP
{
    class Program
    {
        static void DrawDuck(CDuck duck)
        {
            duck.Display();
        }

        static void PlayWithDuck(CDuck duck)
        {
            DrawDuck(duck);
            duck.Quack();
            duck.Fly();
            duck.Dance();
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            MallardDuck mallardDuck = new MallardDuck();
            PlayWithDuck(mallardDuck);

            RedheadDuck redheadDuck = new RedheadDuck();
            PlayWithDuck(redheadDuck);

            RubberDuck rubberDuck = new RubberDuck();
            PlayWithDuck(rubberDuck);

            DecoyDuck decoyDuck = new DecoyDuck();
            PlayWithDuck(decoyDuck);

            ModelDuck modelDuck = new ModelDuck();
            PlayWithDuck(modelDuck);
            modelDuck.SetFlyBehavior(FlyBehaviors.FlyWithWings());
            PlayWithDuck(modelDuck);
        }
    }
}