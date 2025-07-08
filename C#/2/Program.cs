using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1: Divisible by 3 and 4
            Console.WriteLine("Task 1: Check if a number is divisible by 3 and 4");
            Console.Write("Enter a number: ");
            int num1 = int.Parse(Console.ReadLine());
            if (num1 % 3 == 0 && num1 % 4 == 0)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");

            Console.WriteLine("\n------------------------------\n");

            // Task 2: Positive or Negative
            Console.WriteLine("Task 2: Check if number is positive or negative");
            Console.Write("Enter an integer: ");
            int num2 = int.Parse(Console.ReadLine());
            if (num2 < 0)
                Console.WriteLine("negative");
            else
                Console.WriteLine("positive");

            Console.WriteLine("\n------------------------------\n");

            // Task 3: Max and Min of 3 numbers
            Console.WriteLine("Task 3: Find max and min among three numbers");
            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int c = int.Parse(Console.ReadLine());

            int max = Math.Max(a, Math.Max(b, c));
            int min = Math.Min(a, Math.Min(b, c));

            Console.WriteLine("Max element = " + max);
            Console.WriteLine("Min element = " + min);

            Console.WriteLine("\n------------------------------\n");

            // Task 4: Even or Odd
            Console.WriteLine("Task 4: Check if number is even or odd");
            Console.Write("Enter an integer: ");
            int num4 = int.Parse(Console.ReadLine());
            if (num4 % 2 == 0)
                Console.WriteLine("Even");
            else
                Console.WriteLine("Odd");

            Console.WriteLine("\n------------------------------\n");

            // Task 5: Vowel or Consonant
            Console.WriteLine("Task 5: Check if character is vowel or consonant");
            Console.Write("Enter a character: ");
            char ch = char.ToLower(Console.ReadLine()[0]);
            if ("aeiou".Contains(ch))
                Console.WriteLine("vowel");
            else
                Console.WriteLine("consonant");
        }
    }
}
