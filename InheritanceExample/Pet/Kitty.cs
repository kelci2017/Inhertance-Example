using System;
using InheritanceExample.Base;

namespace InheritanceExample.Pet
{
    public class Kitty : Animal, IPet
    {
        public Kitty(bool vegetarian, int legs, string food, string color) : base(vegetarian, legs, food, color)
        {
        }


        public void Play(string toy)
        {
            Console.WriteLine("Kitty is playing " + toy);
        }

        public void Climb()
        {
            Console.WriteLine("Kitty like climbing trees");
        }

        public override void Eat()
        {
            Console.WriteLine("Kitty likes eating " + Food);
        }
    }
}