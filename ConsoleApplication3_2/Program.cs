using System;

namespace ConsoleApplication3_2
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            var age = int.Parse(Console.ReadLine());

            Console.WriteLine("Your name is {0} and age is {1} ", name, age);

            Console.Write("Enter your birthdate: ");

            var birthdate = Console.ReadLine();
            Console.Write("Your birthdate is {0}", birthdate);
            Console.ReadKey();
        }
    }
}