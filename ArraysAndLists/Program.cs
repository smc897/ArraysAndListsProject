using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("numbers = ");
            for (int i = 0; i < 10; i++) Console.Write(numbers[i]+" ");

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            List<int> evens = new List<int>();
            List<int> odds = new List<int>();

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */
            for (int i = 0; i < 10; i++) {
                if (numbers[i] % 2 == 1) odds.Add(numbers[i]);
                else evens.Add(numbers[i]);
            }

            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
            for (int i = 0; i < evens.Count; i++) Console.WriteLine(evens[i]);
            for (int i = 0; i < odds.Count; i++) Console.WriteLine(odds[i]);
        }
    }
}
