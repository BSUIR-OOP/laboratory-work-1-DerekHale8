using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Square : Figure
    {
        private Point A { get; set; }

        private int Length { get; set; }


        public Square(Point a, int length)
        {
            A = a;
            Length = length;
        }

        public override string ToString()
            => $"Square: A({A.xPos}, {A.yPos}), B({A.xPos + Length}, {A.yPos}), C({A.xPos + Length}, {A.yPos + Length}), D({A.xPos}, {A.yPos + Length})";
    }
}
