using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Circle : Figure
    {
        private Point Center { get; set; }
        private int Radius { get; set; }

        public Circle(Point center, int radius)
        {
            Center = center;
            Radius = radius;
        }

        public override string ToString()
            => $"Circle: Center({Center.xPos}, {Center.yPos}), Radius = {Radius}";
    }
}
