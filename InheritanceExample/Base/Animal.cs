using System;
using System.Runtime.InteropServices;

namespace InheritanceExample.Base
{
    public class Animal
    {
        public string Food;
        private string Color;
        protected Animal(bool vegetarian, int legs, string food, string color)
        {
            Food = food;
            Color = color;
            Console.WriteLine($"{GetType().Name} vegetarian is {vegetarian} with color " +
                              $"{color} and has {legs} legs and likes eating {food}");
        }
        public void Sleep()
        {
        }
        public virtual void Eat()
        {
        }
        private void Confidential() {
            Console.WriteLine("This is a confidential method can only be used inside this class");
        }
        public void MakePublic() {
            Confidential();
        }
    }
}