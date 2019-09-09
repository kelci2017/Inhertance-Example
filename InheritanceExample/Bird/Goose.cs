using System;
using InheritanceExample.Base;

namespace InheritanceExample.Bird
{
    public class Goose : Animal, IBird
    {
        public Goose(bool vegetarian, int legs, string food, string color) : base(vegetarian, legs, food, color)
        {
        }

        public void Fly()
        {
            Console.WriteLine("Goose can fly");
        }

        public override void Eat()
        {
            base.Eat();
            Console.WriteLine("Goose eat " + Food);
        }

        public void Walk()
        {
            Console.WriteLine("Goose like waling around the Wascana lake");
        }
        
        //the non-virtual method cannot be overriden
//        public override void Sleep()
//        {
//            
//        }
    }
}