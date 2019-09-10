using System;

namespace InheritanceExample.Crawl
{
    public class Tortoise : Turtle
    {
        public Tortoise(bool vegetarian, int legs, string food, string color) 
            : base(vegetarian, legs, food, color)
        {
        }
        
        public void Walk() {
            Console.WriteLine("Tortoise likes walking slowly");
        }
        
//        public override void Swim() {
//            Console.WriteLine("Normally tortoise don't like swim");
//        }
        
//        public override void Eat() {
//            Console.WriteLine(GetType().Name + " likes eat " + Food);
//        }
        
        public override void Crawl() {
            Console.WriteLine(GetType().Name + " likes walking");
        }
        
    }
}