using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Circle : Figure, IPrint
    {
        public double r, b;

        public Circle(double r) { this.r = r; }

        override public double GetArea()
        {
            return 2 * Math.PI * Math.Pow(r, 2);
        }
        public override string ToString()
        {
            return "Круг. Радиус:" + r + " Площадь:" + GetArea();
        }
        public void Print() { Console.WriteLine(ToString()); }

    }
}
