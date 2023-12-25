using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LoopExample
{
    public static class Example
    {
        public static void CheckNumberIsPrime()
        {
            Console.Write("Enter a positive number: ");

            //Console.ReadLine() will read number entered by user
            int num = int.Parse(Console.ReadLine());

            // 2 is divider to check reminder
            int divider = 2;

            // Calculate square root of entered number
            int maxDivider = (int)Math.Sqrt(num);

            //Variable to check boolean variable 
            bool prime = true;

            //Check if prime variable and divider is less than
            //equal to square root of number
            while (prime && (divider <= maxDivider))
            {
                if (num % divider == 0)
                {
                    //Reminder is 0 means not a prime number
                    prime = false;
                }

                //Increase divider
                divider++;
            }
            if(prime)
            { Console.WriteLine("{0} is a Prime Number." , num); }
            else
            { Console.WriteLine("{0} is not a Prime Number.", num); } 
        }

        public static void GetFactorialofNumber()
        {
            Console.Write("Enter number = ");
            int n = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;
            do
            {
                factorial *= n;
                n--;
            } while (n > 0);
            Console.WriteLine("factorial of n is :  " + factorial);
        }

        public static void PrintingTriangle()
        {
            Console.Write("Enter length = ");
            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }
        }

        public static void PrimeNumbers()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("m = ");
            int m = int.Parse(Console.ReadLine());
            for (int num = n; num <= m; num++)
            {
                bool prime = true;
                int divider = 2;
                int maxDivider = (int)Math.Sqrt(num);
                while (divider <= maxDivider)
                {
                    if (num % divider == 0)
                    {
                        prime = false;
                        break;
                    }
                    divider++;
                }
                if (prime)
                {
                    Console.Write(" " + num);
                }
            }

        }
    }
}
