using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G01_OOP05
{
    internal interface ICircle : IShape
    {
        double Radius { get; set; }
    }
}
