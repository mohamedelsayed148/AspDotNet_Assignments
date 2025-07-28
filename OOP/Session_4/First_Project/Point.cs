using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Project
{
    internal class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        //Define the basic Constructors (use chaining in constructors).
        
        public Point(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Point(int x, int y) : this(x, y, 0)
        {
        }
        public Point(int x) : this(x, 0, 0)
        {
        }
        public Point() : this(0, 0, 0)
        {
        }

        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }

        public static  bool operator  == (Point left, Point right)
        {
            return
                left.X == right.X &&
                left.Y == right.Y &&
                left.Z == right.Z;
        }
        public static bool operator !=(Point left, Point right)
        {
            return
                left.X != right.X ||
                left.Y != right.Y ||
                left.Z != right.Z;
        }

    }
}
