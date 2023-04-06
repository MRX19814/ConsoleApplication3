using System;

namespace ConsoleApplication3_2
{
    class Program
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
    }
}