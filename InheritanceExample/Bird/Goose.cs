using System;
using InheritanceExample.Base;

namespace InheritanceExample.Bird
{
    public class Goose : Animal, IBird
    {
        public Goose(bool vegetarian, int legs, string food, string color) 
            : base(vegetarian, legs, food, color)
        {
            Console.WriteLine("Goose constructor was executed");
        }
        public void Fly()
        {
            Console.WriteLine("Goose can fly");
        }
        public void Walk()
        {
            Console.WriteLine("Goose like waling around the Wascana lake");
        }

        public override void Eat()
        {
            Console.WriteLine($"Is {GetType().Name} eating {Food} now?");
        }

//the non-virtual method cannot be overriden
//        public override void Sleep()
//        {
//            
//        }
    }
}