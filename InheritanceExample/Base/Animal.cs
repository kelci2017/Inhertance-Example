using System;
using System.Runtime.InteropServices;

namespace InheritanceExample.Base
{
    public class Animal
    {
        protected string Food;

        protected Animal(bool vegetarian, int legs, string food, string color)
        {
            Food = food;
            Console.WriteLine(GetType().Name + " vegetarian is " + vegetarian + " with color " + color + " and has " + legs + " legs and likes eating " + food);
        }

        public void Sleep()
        {
            Console.WriteLine(GetType().Name + " is sleeping");
        }

        public virtual void Eat()
        {
            Console.WriteLine(GetType().Name + " is eating " + Food + " (called from Animal class)");
        }
        
        private void Confidential() {
            Console.WriteLine("This is a confidential method can only be used inside this class");
        }

        public void MakePublic() {
            Confidential();
        }
    }
}