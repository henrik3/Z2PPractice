using System;

namespace Z2PPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Color = "Blue";

            Car myCar2 = new Car();
            myCar2.Color = "Red";

            Math myMath = new Math();
            int total = Math.Add(5, 3);


            Math myMath2 = new Math();
            int total2 = Math.Add(6, 12);

            Console.WriteLine(total);
            Console.WriteLine(total2);
        }
    }

    class Car
    {
        public string Color { get; set; }
    }

    class Math
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
