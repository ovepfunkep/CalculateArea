using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator.Shapes
{
    public class Circle : Shape
    {
        public Circle(int R = 0)
        {
            Area = Math.PI * R * R;
        }
    }
}
