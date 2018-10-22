using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figure> fig = new List<Figure>();
            fig.Add(new Rectangle(10, 12));
            fig.Add(new Circle(10));
            fig.Add(new Square(10));
            foreach (Figure f in fig)
            {
                Console.WriteLine(f);
            
            }

            Matrix<Figure> matrix =new Matrix<Figure>(3,3,3,new FigureMatrixCheckEmpty());

            matrix[0, 0, 1] = fig[0];
            matrix[0, 1, 0] = fig[1];
            matrix[1, 0, 0] = fig[2];

            Console.WriteLine(matrix);

            fig.Sort();
            foreach (Figure f in fig)
            {
                Console.WriteLine(f);

            } 
            int a = 10;
            int nn = a;
            Console.Read();
        }
    }
}
