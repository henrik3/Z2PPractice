using System;

namespace Z2PPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            Fish myFish = new Fish();

            myDog.Breathe();
            myFish.Breathe();
        }
    }

    abstract class Animal
    {
        public String name { get; set; }

        // Virtual is allowing subclasses to override the functionality of this class
        // Abstract is forcing them to so
        public virtual void Breathe()
        {
            Console.WriteLine("I'm breathing air");
        }
    }

    class Dog : Animal
    {

    }

    class Fish : Animal
    {
        public override void Breathe()
        {
            Console.WriteLine("I'm breathing under water");
        }
    }
 
}
