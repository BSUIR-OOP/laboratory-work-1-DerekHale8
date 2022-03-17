using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FiguresList fList = new FiguresList(new Figure[] {
                new Line(new Point(10, 30), new Point(20, 30)),
                new Triangle(new Point(10, 20), new Point(20, 20), new Point(10, 20)),
                new Rectangle(new Point(40, 50), 30, 10),
                new Square(new Point(10, 10), 10),
                new Circle(new Point(20, 30), 10),
                new Ellipse(new Point(50, 20), 20, 30)
            }) ;
            fList.StartDrawing();
            Console.ReadLine();
        }
    }
}
