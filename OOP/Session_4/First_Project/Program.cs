namespace First_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(10, 10, 10);
            Point p2 = new Point(10, 10, 10);
            //Console.WriteLine(p1.ToString());

            // Read from the User the Coordinates for 2 points P1, P2 (Check the input using try Pares, Parse, Convert).
            //Point? p1 = null , p2 = null ;
            //Console.WriteLine("Enter coordinates for Point 1 (X Y Z):");
            //string input1 = Console.ReadLine()!;
            //string[] coordinates1 = input1.Split(' ');
            //int x1, y1, z1;
            //if (coordinates1.Length == 3 && 
            //    int.TryParse(coordinates1[0], out x1) && 
            //    int.TryParse(coordinates1[1], out y1) && 
            //    int.TryParse(coordinates1[2], out z1))
            //{
            //    p1 = new Point(x1, y1, z1);
            //    Console.WriteLine(p1.ToString());
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input for Point 1. Please enter three integers.");
            //}
            //Console.WriteLine("Enter coordinates for Point 2 (X Y Z):");
            //string input2 = Console.ReadLine()!;
            //string[] coordinates2 = input2.Split(' ');
            //int x2, y2, z2;
            //if (coordinates2.Length == 3 && 
            //    int.TryParse(coordinates2[0], out x2) && 
            //    int.TryParse(coordinates2[1], out y2) && 
            //    int.TryParse(coordinates2[2], out z2))
            //{
            //    p2 = new Point(x2, y2, z2);
            //    Console.WriteLine(p2.ToString());
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input for Point 2. Please enter three integers.");
            //}


            if (p1 == p2)
            {
                Console.WriteLine("p1 == p2");
            }
            else
            {
                Console.WriteLine("p1 != p2");
            }

            




        }
    }
}
