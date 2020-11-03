using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace FizzBuzz_Console
{
    class FirstSolution
    {
        public static void Solution(int number)
        {
            var runTime = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 0; i < number; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            runTime.Stop();

            Console.WriteLine("\nElapsed runtime " + runTime.ElapsedMilliseconds);
        }
    }
}
