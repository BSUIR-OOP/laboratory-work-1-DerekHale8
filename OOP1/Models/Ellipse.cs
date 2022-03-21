using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Ellipse : Figure
    {
        private Point Center { get; set; }
        private int A { get; set; }

        private int B { get; set; }


        public Ellipse(Point center, int a, int b)
        {
            Center = center;
            A = a;
            B = b;
        }

        public override string ToString()
            => $"Ellipse: Center({Center.xPos}, {Center.yPos}), Semi-minor axis = {A}, Semi-major axis = {B}";
    }
}
