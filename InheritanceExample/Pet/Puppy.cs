using System;
using InheritanceExample.Base;

namespace InheritanceExample.Pet
{
    public class Puppy : Animal, IPet
    {
        public Puppy(bool vegetarian, int legs, string food, string color) : base(vegetarian, legs, food, color)
        {
        }

        public void Play(string toy)
        {
            Console.WriteLine("Putty likes playing "+ toy);
        }

        public void Bark()
        {
            Console.WriteLine("Putty will bark once met strangers");
        }

        public override void Eat()
        {
            base.Eat();
            Console.WriteLine("Puppy likes eating " + Food);
        }
    }
}