using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator.Shapes
{
    public class Triangle : Shape
    {
        public bool Rectangular = false;

        static bool IsRectangular(List<int> sides) =>
            ((sides[0] ^ 2) == (sides[1] ^ 2 + sides[2] ^ 2)) ||
            ((sides[1] ^ 2) == (sides[0] ^ 2 + sides[2] ^ 2)) ||
            ((sides[2] ^ 2) == (sides[1] ^ 2 + sides[0] ^ 2));

        static bool IsTriangle(int side1, int side2, int side3) => 
            side1 <= side2 + side3 && 
            side2 <= side1 + side3 &&
            side3 <= side1 + side2 && 
            side1 != 0 && side2 != 0 && side3 != 0;

        static double SearchTriangleArea(int side1, int side2, int side3)
        {
            double p = (side1 + side2 + side3) / 2;
            return Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
        }


        public Triangle(int side1 = 0, int side2 = 0, int side3 = 0)
        {
            if (!IsTriangle(side1, side2, side3)) return;
            Area = SearchTriangleArea(side1, side2, side3);
            Rectangular = IsRectangular(new List<int> { side1, side2, side3 });
        }
    }
}
