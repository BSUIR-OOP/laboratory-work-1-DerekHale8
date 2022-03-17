using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Triangle : Figure
    {
        private Point A { get; set; }

        private Point B { get; set; }

        private Point C { get; set; }

        private Triangle() { }

        public Triangle(Point a, Point b, Point c)
        {
            A = a;
            B = b;
            C = c;
        }

        public override string ToString()
            => $"Triangle: A({A.xPos}; {A.yPos}); B({B.xPos}; {B.yPos}); C({C.xPos}; {C.yPos})";
    }
}
