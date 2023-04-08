using System;

namespace ConsoleApplication3_2
{
    /*class Program
    {
        static void Main(string[] args)
        {
            string MyName = "Alexandr";
            byte MyAge = 23;
            bool IPate = false;
            double ShoesSize = 45.5;

            Console.WriteLine("My name " + MyName);
            Console.WriteLine("My age " + MyAge);
            Console.WriteLine("Do you have any pets? " + IPate);
            Console.WriteLine("My foot size " + ShoesSize);
            Console.ReadKey();
        } 
    }*/

    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            byte age = checked ((byte) int.Parse(Console.ReadLine()));
            Console.WriteLine("Your name is {0} and age is {1} ", name, age);
            Console.WriteLine("What is your favorite day of week? ");
            DayOfWeek day = (DayOfWeek) int.Parse((Console.ReadLine()));
            Console.WriteLine("Your favorite day is {0}", day);
            Console.ReadKey();
        }
    }
}