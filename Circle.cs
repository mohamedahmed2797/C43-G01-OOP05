using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G01_OOP05
{

    internal class Circle : ICircle
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;

        }
        public double Area
        {
            get { return 3.14 * Radius * Radius; }

        }
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"the Circle area = {Area}");
        }

    }


}
