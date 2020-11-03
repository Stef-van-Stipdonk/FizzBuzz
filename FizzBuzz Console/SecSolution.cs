using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz_Console
{
    class SecSolution
    {
        public static void Solution(int number)
        {
            /*
            * Write a program that prints the numbers from 1 to 100. 
            * But for multiples of three print “Fizz” instead of the number and for the multiples of five print “Buzz”. 
            * For numbers which are multiples of both three and five print “FizzBuzz”.
            */
            var runTime = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 0; i < number; i++)
            {
                string x = "";
                if (i % 3 == 0 && i % 5 == 0)
                {
                    x += "FizzBuzz";
                }
                else if (i % 3 == 0)
                {
                    x += "Fizz";
                }
                else if (i % 5 == 0)
                {
                    x += "Buzz";
                }
                else
                {
                    x += i.ToString();
                }
                Console.WriteLine(x);
            }

            runTime.Stop();

            Console.WriteLine("\nElapsed runtime " + runTime.ElapsedMilliseconds);
        }
    }
}
