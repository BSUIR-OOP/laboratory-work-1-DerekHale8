using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class FiguresList
    {
        private List<Figure> figures;

        public FiguresList(Figure[] fig)   
        {
            figures = new List<Figure>();
            for (int i = 0; i < fig.Length; i++)
                figures.Add(fig[i]);
        }

        public void StartDrawing()
        {
            foreach (Figure f in figures)
                Console.WriteLine(f);
        }
    }
}
