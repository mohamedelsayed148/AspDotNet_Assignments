using Session_5.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_5.Classes
{
    internal class Circle : ICircle
    {
        public int Area { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void DisplayShapeInfo()
        {
            Console.WriteLine("This is a Circle.");
        }
    }
}
