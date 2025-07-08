using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1. Enter a number and print it
            Console.WriteLine("== Task 1: Enter a number and print it ==");
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You entered: " + number);
            Console.WriteLine();
            #endregion

            #region 2. Convert a string with non-numeric characters to integer
            Console.WriteLine("== Task 2: Convert non-numeric string to integer ==");
            string input = "123abc";
            try
            {
                int result = int.Parse(input); // Will throw exception
                Console.WriteLine("Result: " + result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Cannot convert '123abc' to integer (FormatException).");
            }
            Console.WriteLine();
            #endregion

            #region 3. Perform arithmetic with floating-point numbers
            Console.WriteLine("== Task 3: Floating-point arithmetic ==");
            float num1 = 10.5f;
            float num2 = 3.2f;
            float floatResult = num1 / num2;
            Console.WriteLine("Result: " + floatResult);
            Console.WriteLine();
            #endregion

            #region 4. Extract a substring from a string
            Console.WriteLine("== Task 4: Extract substring ==");
            string text = "Hello World!";
            string sub = text.Substring(6, 5); // "World"
            Console.WriteLine("Substring: " + sub);
            Console.WriteLine();
            #endregion

            #region 5. Value type assignment and modification
            Console.WriteLine("== Task 5: Value Type Behavior ==");
            int x = 5;
            int y = x;
            x++;
            Console.WriteLine("x = " + x); // 6
            Console.WriteLine("y = " + y); // 5
            Console.WriteLine();
            #endregion

            #region 6. Reference type assignment and modification
            Console.WriteLine("== Task 6: Reference Type Behavior ==");
            Point p1 = new Point();
            p1.X = 5;
            Point p2 = p1;
            p2.X = 10;
            Console.WriteLine("p1.X = " + p1.X); // 10
            Console.WriteLine("p2.X = " + p2.X); // 10
            Console.WriteLine();
            #endregion

            #region 7. Concatenate two string variables
            Console.WriteLine("== Task 7: String Concatenation ==");
            string first = "Hello ";
            string second = "World!";
            string combined = first + second;
            Console.WriteLine("Combined String: " + combined);
            Console.WriteLine();
            #endregion

            #region 8. Logic & Conversion - Convert.ToInt32(!(30 < 20))
            Console.WriteLine("== Task 8: Logical NOT and Convert.ToInt32 ==");
            int d;
            d = Convert.ToInt32(!(30 < 20)); // true → 1
            Console.WriteLine("Result of d = Convert.ToInt32(!(30 < 20)) is: " + d);
            Console.WriteLine();
            #endregion

            #region 9. Integer division and modulus with string output
            Console.WriteLine("== Task 9: Integer division and modulus ==");
            Console.WriteLine(13 / 2 + " " + 13 % 2); // "6 1"
            Console.WriteLine();
            #endregion

            #region 10. Complex expression with if-else and increments
            Console.WriteLine("== Task 10: Conditional with increments ==");
            int num = 1, z = 5;
            if (!(num <= 0))
                Console.WriteLine(++num + z++ + " " + ++z);  // → 2 + 5 = 7, z=7 → "7 7"
            else
                Console.WriteLine(--num + z-- + " " + --z);
            Console.WriteLine();
            #endregion
        }
    }

    class Point
    {
        public int X;
    }

}
