using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G01_OOP05
{
    internal class Rectangle : IRectangle
    {
        public double Width { get; set; }
        public Rectangle(double width , double height)
        {
            Width = width;
            Height = height;      
        }
        public double Height { get; set; }

        public double Area
        {
            get { return Width * Height; } 
        }
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"the Rectangle Area = {Area}");
        }
    
    }
}
