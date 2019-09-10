using System;
using InheritanceExample.Bird;
using InheritanceExample.Crawl;
using InheritanceExample.Pet;
using InheritanceExample.Toy;

namespace InheritanceExample
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("***************************  Toy  ***************************************");
            
            var babyCube = new BabyCube(10, "VTech");
            babyCube.Describe();
            babyCube.SetLevel(1);
            
            Console.WriteLine("***************************  Birds  ***************************************");
            
            //Birds (the parent constructor was executed first before the child constructor)
            var goose = new Goose(true, 2, "seeds", "gray");

            Console.WriteLine("***************************  Pets  ***************************************");
            
            //Pets(child can have its own methods Bark or Climb)
            var puppy = new Puppy(false, 4, "bones", "yellow");
            puppy.Bark();

            Console.WriteLine("---------------------------------");
            
            var kitty = new Kitty(false, 4, "fish", "yellow");
            kitty.Climb();

            Console.WriteLine("***************************  Crawls  ***************************************");
            
            //Crawls(child can use its implemented interface methods and call the parent public methods)
            var turtle = new Turtle(false, 4,"insects", "brown");
            turtle.Crawl();
            turtle.Eat();
            //turtle.Confidential();
            turtle.MakePublic();
            
            Console.WriteLine("---------------------------------");
            
            var crocodile = new Crocodile(false, 4, "fish", "gray");
            crocodile.Sleep();
            crocodile.Crawl();
            
            Console.WriteLine("---------------------------------");
            
            var tortoise = new Tortoise(true, 4, "grass", "gray");
            tortoise.Sleep();
            tortoise.Crawl();
            tortoise.Walk();
        }
    }
}