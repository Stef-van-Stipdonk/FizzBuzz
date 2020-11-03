using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace FizzBuzz_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Write a program that prints the numbers from 1 to 100. 
             * But for multiples of three print “Fizz” instead of the number and for the multiples of five print “Buzz”. 
             * For numbers which are multiples of both three and five print “FizzBuzz”.
             */
            Console.WriteLine("Choose a solution");

            List<string> list = new List<string> { "1: First Solution", "2: Secound Solution" };

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            int solutionNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose a FizzBuzz number");
            int chosenRunNumber = Convert.ToInt32(Console.ReadLine());
            switch (solutionNumber)
            {
                case 1:
                    FirstSolution.Solution(chosenRunNumber);
                    break;
                case 2:
                    SecSolution.Solution(chosenRunNumber);
                    break;
            }
        }
    }
}
