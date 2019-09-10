
using System;

namespace InheritanceExample.Toy
{
    public class BabyCube : Base.Toy
    {
        public BabyCube(double price, string producer)
        {
            Price = price;
            Producer = producer;
        }

        protected override double Price { get; }
        protected override string Producer { get; }
        public override void SetLevel(int level)
        {
            Console.WriteLine($"{GetType().Name} is for kids over {level} year old.");
        }
    }
}