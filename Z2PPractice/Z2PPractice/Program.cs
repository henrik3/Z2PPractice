using System;

namespace Z2PPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            myDog.Name = "Bob";
            myDog.NumberOfLegs = 4;
            myDog.Bark();

            Labrador myLab = new Labrador();
            myLab.Bark();
            myLab.Breathe();

            Console.WriteLine(myDog.Name);
        }
    }
    // The Animal class inherits from interface IAnimal
    class Animal
    {
        public string Name { get; set; }
        public string Color { get; set; }
        
        public void Breathe()
        {
            Console.WriteLine("I'm breathing");
        }

        public void Eat()
        {

        }
    }

    class Dog : Animal
    {
        public int NumberOfLegs { get; set; }
        public void Bark()
        {
            Console.WriteLine("Woof!");
        }
        
    }

    class Labrador : Dog
    {

    }
  
}
