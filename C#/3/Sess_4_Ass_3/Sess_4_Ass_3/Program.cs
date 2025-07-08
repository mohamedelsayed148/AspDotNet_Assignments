namespace Sess_4_Ass_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 6 - Print numbers from 1 to user input
            Console.Write("Task 6 - Enter an integer: ");
            int num6 = int.Parse(Console.ReadLine());
            Console.Write("Output: ");
            for (int i = 1; i <= num6; i++)
            {
                Console.Write(i + (i < num6 ? ", " : ""));
            }
            Console.WriteLine("\n");

            // 7 - Multiplication table up to 12
            Console.Write("Task 7 - Enter a number for multiplication table: ");
            int num7 = int.Parse(Console.ReadLine());
            Console.Write("Output: ");
            for (int i = 1; i <= 12; i++)
            {
                Console.Write(num7 * i + " ");
            }
            Console.WriteLine("\n");

            // 8 - Print even numbers from 1 to input
            Console.Write("Task 8 - Enter a number to list even numbers: ");
            int num8 = int.Parse(Console.ReadLine());
            Console.Write("Output: ");
            for (int i = 2; i <= num8; i += 2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");

            // 9 - Power of a number
            Console.Write("Task 9 - Enter base: ");
            int baseNum = int.Parse(Console.ReadLine());
            Console.Write("Enter exponent: ");
            int exp = int.Parse(Console.ReadLine());
            int power = 1;
            for (int i = 0; i < exp; i++)
            {
                power *= baseNum;
            }
            Console.WriteLine($"Output: {power}\n");

            // 10 - Marks of 5 subjects
            Console.WriteLine("Task 10 - Enter marks of five subjects separated by space: ");
            string[] marksInput = Console.ReadLine().Split();
            int total = 0;
            foreach (var mark in marksInput)
            {
                total += int.Parse(mark);
            }
            double average = total / 5.0;
            double percentage = (total / 500.0) * 100;
            Console.WriteLine($"Total marks = {total}");
            Console.WriteLine($"Average Marks = {average}");
            Console.WriteLine($"Percentage = {percentage}\n");

            // 11 - Days in a month
            Console.Write("Task 11 - Enter month number (1-12): ");
            int month = int.Parse(Console.ReadLine());
            int days;
            switch (month)
            {
                case 2: days = 28; break; // Not accounting for leap years
                case 4:
                case 6:
                case 9:
                case 11: days = 30; break;
                default: days = 31; break;
            }
            Console.WriteLine($"Days in Month: {days}\n");

            // 12 - Simple Calculator
            Console.WriteLine("Task 12 - Simple Calculator");
            Console.Write("Enter first number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter operator (+, -, *, /): ");
            char op = Console.ReadLine()[0];
            Console.Write("Enter second number: ");
            double num2 = double.Parse(Console.ReadLine());
            double result = 0;
            switch (op)
            {
                case '+': result = num1 + num2; break;
                case '-': result = num1 - num2; break;
                case '*': result = num1 * num2; break;
                case '/': result = num2 != 0 ? num1 / num2 : double.NaN; break;
                default: Console.WriteLine("Invalid operator."); break;
            }
            Console.WriteLine($"Result: {result}\n");

            // 13 - Reverse of a string
            Console.Write("Task 13 - Enter a string: ");
            string str = Console.ReadLine();
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine("Reversed string: " + new string(arr) + "\n");

            // 14 - Reverse of an integer
            Console.Write("Task 14 - Enter an integer: ");
            int number = int.Parse(Console.ReadLine());
            int reversed = 0;
            while (number != 0)
            {
                reversed = reversed * 10 + number % 10;
                number /= 10;
            }
            Console.WriteLine("Reversed number: " + reversed + "\n");

            // 15 - Prime numbers in range
            Console.Write("Task 15 - Enter starting number of range: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Enter ending number of range: ");
            int end = int.Parse(Console.ReadLine());
            Console.WriteLine("The prime numbers between {0} and {1} are:", start, end);
            for (int i = start; i <= end; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();

            // 17 - 3 Points on the same line
            Console.WriteLine("Enter coordinates of three points:");

            Console.Write("Enter x1: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Enter y1: ");
            double y1 = double.Parse(Console.ReadLine());

            Console.Write("Enter x2: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("Enter y2: ");
            double y2 = double.Parse(Console.ReadLine());

            Console.Write("Enter x3: ");
            double x3 = double.Parse(Console.ReadLine());
            Console.Write("Enter y3: ");
            double y3 = double.Parse(Console.ReadLine());

            // Calculate the area using determinant formula
            double area = 0.5 * Math.Abs(x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));

            if (area == 0)
            {
                Console.WriteLine("The points lie on a straight line (collinear).");
            }
            else
            {
                Console.WriteLine("The points do NOT lie on a straight line.");
            }

            // 18 - Worker Efficiency
            Console.Write("Enter time taken to complete the task (in hours): ");
            double time = double.Parse(Console.ReadLine());

            if (time >= 2 && time < 3)
            {
                Console.WriteLine("Highly efficient");
            }
            else if (time >= 3 && time < 4)
            {
                Console.WriteLine("You need to improve speed");
            }
            else if (time >= 4 && time <= 5)
            {
                Console.WriteLine("You need training to improve speed");
            }
            else if (time > 5)
            {
                Console.WriteLine("You are to leave the company");
            }
            else
            {
                Console.WriteLine("Invalid time entered or task completed too quickly.");
            }

        }
        static bool IsPrime(int n)
        {
            if (n <= 1) return false;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
    }
}
