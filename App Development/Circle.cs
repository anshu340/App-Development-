using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Development
{
    class Circle
    {
        public const double PI = 3.14;
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double CalculateArea()
        {
            return PI * Radius * Radius;
        }
    }
}
