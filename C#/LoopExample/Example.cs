using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
