using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Line : Figure
    {
        private Point A { get; set; }
        private Point B { get; set; }


        public Line(Point a, Point b)
        {
            A = a;
            B = b;
        }

        public override string ToString()
            => $"Line: A({A.xPos}; {A.yPos}); B({B.xPos}; {B.yPos})";
    }
}
