using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    public class Shape
    {
        public double Area;
        
        public Shape(Shape shape = null)
        {
            Area = shape == null ? 0 : shape.Area;
        }
    }
}
