using System;
using InheritanceExample.Base;

namespace InheritanceExample.Crawl
{
    public class Turtle: Animal, ICrawl, IPet
    {
        public Turtle(bool vegetarian, int legs, string food, string color)
            : base(vegetarian, legs, food, color)
        {
        }

        public virtual void Crawl()
        {
            Console.WriteLine("Turtle is crawling slowly.");
        }

        public sealed override void Eat()
        {
            Console.WriteLine($"Turtle eats {Food}");
        }

        public void Swim()
        {
            Console.WriteLine("Turtle can swim");
        }

        public void Play(string toy)
        {
        }
    }
}