using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopExample
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Check a number is prime or not");
            Example.CheckNumberIsPrime();
            Console.WriteLine("Press <Enter> to execute Next Program... ");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }

            Console.WriteLine("--------------------------------------------------------------------------------");

            Console.WriteLine("Calculate Factorial of a number");
            Example.GetFactorialofNumber();

            Console.WriteLine("Press <Enter> to execute Next Program... ");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }

            Console.WriteLine("--------------------------------------------------------------------------------");

            Console.WriteLine("Printing a Triangle");
            Example.PrintingTriangle();

            Console.WriteLine("Press <Enter> to execute Next Program... ");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }

            Console.WriteLine("--------------------------------------------------------------------------------");


            Console.WriteLine("Prime Numbers in an Interval");
            Example.PrimeNumbers();
            Console.ReadLine();
        }
    }
}
