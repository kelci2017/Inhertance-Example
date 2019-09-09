using System;
using InheritanceExample.Base;

namespace InheritanceExample.Bird
{
    public class Sparrow: Animal, IBird
    {
        public Sparrow(bool vegetarian, int legs, string food, string color) : base(vegetarian, legs, food, color)
        {
        }

        public void Fly()
        {
            Console.WriteLine("Sparrow is flying");
        }

        public override void Eat()
        {
            Console.WriteLine("Sparrow eats " + Food);
        }

        public void Sing(string song)
        {
            Console.WriteLine("Sparrow is singing" + song);
        }
    }
}