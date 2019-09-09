using System;
using InheritanceExample.Base;

namespace InheritanceExample.Crawl
{
    public class Crocodile : Animal, ICrawl
    {
        public Crocodile(bool vegetarian, int legs, string food, string color) : base(vegetarian, legs, food, color)
        {
        }

        public void Crawl()
        {
            Console.WriteLine("Crocodile is crawling on the beach");
        }

        public override void Eat()
        {
            Console.WriteLine("Crocodile eats " + Food);
            base.Eat();
        }
    }
}