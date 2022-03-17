using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Rectangle : Figure
    {
        private Point A { get; set; }

        private int Height { get; set; }

        private int Width { get; set; }

        private Rectangle() { }

        public Rectangle(Point a, int height, int width)
        {
            A = a;
            Height = height;
            Width = width;
        }

        public override string ToString()
            => $"Rectangle: A({A.xPos}, {A.yPos}), B({A.xPos + Width}; {A.yPos}), C({A.xPos + Width}, {A.xPos + Height}), D({A.xPos}, {A.yPos + Height})";
    }
}
