using System;

namespace InheritanceExample.Base
{
    public abstract class Toy
    {
        protected abstract double Price { get; }
        protected abstract string Producer { get; }

       public void Describe()
       {
           Console.WriteLine($"{GetType().Name} is produced by {Producer} and price is {Price} dollars");
       }

       public abstract void SetLevel(int level);
    }
}