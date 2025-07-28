namespace Third_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Duration duration = new Duration(666);
            Console.WriteLine(duration.ToString());

            Duration d2 = new Duration(1, 10, 100);
            Console.WriteLine(duration.Equals(d2));

            Console.WriteLine(duration.GetHashCode());

            Console.WriteLine(duration);


            
        }
    }
}
