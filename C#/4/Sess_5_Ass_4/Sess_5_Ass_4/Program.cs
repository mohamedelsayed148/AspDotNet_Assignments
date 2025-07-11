namespace Sess_5_Ass_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 19 - Identity Matrix
            Console.WriteLine("=== Question 19: Identity Matrix ===");
            Console.Write("Enter the size of identity matrix (n): ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nIdentity Matrix of size {n}x{n}:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                        Console.Write("1 ");
                    else
                        Console.Write("0 ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            #endregion

            #region Question 20 - Sum of Array Elements
            Console.WriteLine("=== Question 20: Sum of Array Elements ===");
            Console.Write("Enter the number of elements: ");
            int n20 = int.Parse(Console.ReadLine());

            int[] arr20 = new int[n20];
            Console.WriteLine("Enter the array elements:");
            for (int i = 0; i < n20; i++)
            {
                Console.Write($"Element {i + 1}: ");
                arr20[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            for (int i = 0; i < arr20.Length; i++)
            {
                sum += arr20[i];
            }

            Console.WriteLine($"Sum of all elements: {sum}");
            Console.WriteLine();
            #endregion

            #region Question 21 - Merge Two Sorted Arrays
            Console.WriteLine("=== Question 21: Merge Two Sorted Arrays ===");
            Console.Write("Enter the size of arrays: ");
            int size21 = int.Parse(Console.ReadLine());

            int[] arr21_1 = new int[size21];
            int[] arr21_2 = new int[size21];

            Console.WriteLine("Enter elements for first array (sorted):");
            for (int i = 0; i < size21; i++)
            {
                Console.Write($"Element {i + 1}: ");
                arr21_1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter elements for second array (sorted):");
            for (int i = 0; i < size21; i++)
            {
                Console.Write($"Element {i + 1}: ");
                arr21_2[i] = int.Parse(Console.ReadLine());
            }

            int[] merged = new int[size21 * 2];
            int i1 = 0, i2 = 0, mergedIndex = 0;

            // Merge arrays in sorted order
            while (i1 < size21 && i2 < size21)
            {
                if (arr21_1[i1] <= arr21_2[i2])
                {
                    merged[mergedIndex] = arr21_1[i1];
                    i1++;
                }
                else
                {
                    merged[mergedIndex] = arr21_2[i2];
                    i2++;
                }
                mergedIndex++;
            }

            // Add remaining elements
            while (i1 < size21)
            {
                merged[mergedIndex] = arr21_1[i1];
                i1++;
                mergedIndex++;
            }

            while (i2 < size21)
            {
                merged[mergedIndex] = arr21_2[i2];
                i2++;
                mergedIndex++;
            }

            Console.WriteLine("Merged sorted array:");
            for (int i = 0; i < merged.Length; i++)
            {
                Console.Write(merged[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region Question 22 - Frequency Count
            Console.WriteLine("=== Question 22: Frequency Count ===");
            Console.Write("Enter the number of elements: ");
            int n22 = int.Parse(Console.ReadLine());

            int[] arr22 = new int[n22];
            Console.WriteLine("Enter the array elements:");
            for (int i = 0; i < n22; i++)
            {
                Console.Write($"Element {i + 1}: ");
                arr22[i] = int.Parse(Console.ReadLine());
            }

            bool[] visited = new bool[n22];

            Console.WriteLine("\nFrequency of each element:");
            for (int i = 0; i < n22; i++)
            {
                if (!visited[i])
                {
                    int count = 1;
                    for (int j = i + 1; j < n22; j++)
                    {
                        if (arr22[i] == arr22[j])
                        {
                            count++;
                            visited[j] = true;
                        }
                    }
                    Console.WriteLine($"Element {arr22[i]} appears {count} time(s)");
                }
            }
            Console.WriteLine();
            #endregion

            #region Question 23 - Maximum and Minimum Element
            Console.WriteLine("=== Question 23: Maximum and Minimum Element ===");
            Console.Write("Enter the number of elements: ");
            int n23 = int.Parse(Console.ReadLine());

            int[] arr23 = new int[n23];
            Console.WriteLine("Enter the array elements:");
            for (int i = 0; i < n23; i++)
            {
                Console.Write($"Element {i + 1}: ");
                arr23[i] = int.Parse(Console.ReadLine());
            }

            int max = arr23[0];
            int min = arr23[0];

            for (int i = 1; i < n23; i++)
            {
                if (arr23[i] > max)
                    max = arr23[i];
                if (arr23[i] < min)
                    min = arr23[i];
            }

            Console.WriteLine($"Maximum element: {max}");
            Console.WriteLine($"Minimum element: {min}");
            Console.WriteLine();
            #endregion

            #region Question 24 - Second Largest Element
            Console.WriteLine("=== Question 24: Second Largest Element ===");
            Console.Write("Enter the number of elements: ");
            int n24 = int.Parse(Console.ReadLine());

            int[] arr24 = new int[n24];
            Console.WriteLine("Enter the array elements:");
            for (int i = 0; i < n24; i++)
            {
                Console.Write($"Element {i + 1}: ");
                arr24[i] = int.Parse(Console.ReadLine());
            }

            int largest = int.MinValue;
            int secondLargest = int.MinValue;

            for (int i = 0; i < n24; i++)
            {
                if (arr24[i] > largest)
                {
                    secondLargest = largest;
                    largest = arr24[i];
                }
                else if (arr24[i] > secondLargest && arr24[i] != largest)
                {
                    secondLargest = arr24[i];
                }
            }

            if (secondLargest == int.MinValue)
                Console.WriteLine("No second largest element found (all elements are same)");
            else
                Console.WriteLine($"Second largest element: {secondLargest}");
            Console.WriteLine();
            #endregion

            #region Question 25 - Longest Distance Between Equal Elements
            Console.WriteLine("=== Question 25: Longest Distance Between Equal Elements ===");
            Console.Write("Enter the number of elements: ");
            int n25 = int.Parse(Console.ReadLine());

            int[] arr25 = new int[n25];
            Console.WriteLine("Enter the array elements:");
            for (int i = 0; i < n25; i++)
            {
                Console.Write($"Element {i + 1}: ");
                arr25[i] = int.Parse(Console.ReadLine());
            }

            int maxDistance = 0;
            int element1 = -1, element2 = -1;

            for (int i = 0; i < n25; i++)
            {
                for (int j = i + 1; j < n25; j++)
                {
                    if (arr25[i] == arr25[j])
                    {
                        int distance = j - i - 1; // Number of cells between
                        if (distance > maxDistance)
                        {
                            maxDistance = distance;
                            element1 = i;
                            element2 = j;
                        }
                    }
                }
            }

            if (maxDistance == 0)
                Console.WriteLine("No equal elements found or all equal elements are adjacent");
            else
            {
                Console.WriteLine($"Longest distance between equal elements: {maxDistance}");
                Console.WriteLine($"Between positions {element1 + 1} and {element2 + 1} (value: {arr25[element1]})");
            }
            Console.WriteLine();
            #endregion

            #region Question 26 - Reverse Words
            Console.WriteLine("=== Question 26: Reverse Words ===");
            Console.Write("Enter a sentence: ");
            string input = Console.ReadLine();

            string[] words = input.Split(' ');
            Array.Reverse(words);

            Console.WriteLine(string.Join(" ", words));
            Console.WriteLine();
            #endregion

            #region Question 27 - Copy Multidimensional Array
            Console.WriteLine("=== Question 27: Copy Multidimensional Array ===");
            Console.Write("Enter number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Enter number of columns: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] arr27_1 = new int[rows, cols];
            int[,] arr27_2 = new int[rows, cols];

            Console.WriteLine("Enter elements for the first array:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Element [{i},{j}]: ");
                    arr27_1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Copy elements from first array to second array
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    arr27_2[i, j] = arr27_1[i, j];
                }
            }

            Console.WriteLine("\nSecond array (copied from first):");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(arr27_2[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            #endregion

            #region Question 28 - Print Array in Reverse Order
            Console.WriteLine("=== Question 28: Print Array in Reverse Order ===");
            Console.Write("Enter the number of elements: ");
            int n28 = int.Parse(Console.ReadLine());

            int[] arr28 = new int[n28];
            Console.WriteLine("Enter the array elements:");
            for (int i = 0; i < n28; i++)
            {
                Console.Write($"Element {i + 1}: ");
                arr28[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nArray in reverse order:");
            for (int i = n28 - 1; i >= 0; i--)
            {
                Console.Write(arr28[i] + " ");
            }
            Console.WriteLine();
            #endregion

        }
    }
}
