using System;

namespace ConsoleApplication3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            const string MyName = "Alexandr";
            Console.WriteLine(MyName);
            Console.WriteLine("I am 23 years old");
            Console.WriteLine("I live in St. Petersburg");
            Console.WriteLine("\u0023");
            Console.ReadKey();
        }
    }
}