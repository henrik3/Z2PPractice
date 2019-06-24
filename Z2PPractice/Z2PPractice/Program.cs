using System;

namespace Z2PPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Add(4, 5));
        }
    }

    static class Math
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public static int Add(string b, int a)
        {
            return a + b;
        }
    }
 
}
