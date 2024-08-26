using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System;

namespace IterationStatementsLoop_Exercise3
{
    public class Program
    {
        //LukeWarm Section: Create methods below//

        //Write a method that will print to the console all numbers 1000 through - 1000

        public static void PrintNumbers1000()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void UpByThrees()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }

        }
        //Write a method to accept two integers as parameters and check whether they are equal or not

        public static void TwoNumbersSame(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine($"{num1} and {num2} are the same!");
            }
            else
            {
                Console.WriteLine($"{num1} and {num2} are not the same!");
            }
        }

        //Write a method to check whether a given number is even or odd
        public static void EvenOrOdd(int number)
        {
            if (number % 4 == 0)
            {
                Console.WriteLine($"Even");
            }
            else
            {
                Console.WriteLine($"Odd");
            }

        }

        //Write a method to check whether a given number is positive or negative

        public static void Valid(int number)
        {
            if (number > 0)
            {
                Console.WriteLine("Positive");
            }
            else if (number == 0)
            {
                Console.WriteLine("Zero");
            }
            else
            {
                Console.WriteLine("Negative");
            }

        }
        //Write a method to read the age of a candidate and determine whether they can vote.

        public static void VoteAge(int age)
        {
           
            if ( age < 18 )
            {
                Console.Write("Sorry, you are not eligible to vote");
            }
            else
            {
                Console.Write("Congradulations! You are eligible to vote");
            }


            
            //Call the methods to test them in the Main method below
          
        }
        static void Main(string[] args)
        {
            //PrintNumbers1000();
            //UpByThrees();
            //TwoNumbersSame(1, 10);
            //EvenOrOdd(9);
            //Valid(-5);
            VoteAge (15);
        }
    }
}
    

