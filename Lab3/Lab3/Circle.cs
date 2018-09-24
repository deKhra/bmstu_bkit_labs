using System;


namespace Lab3
{
    class Circle : Figure, IPrint
    {
        public double radius;

        public Circle(double r) { this.radius = r; }

        override public double GetArea()
        {
            return 2 * Math.PI * Math.Pow(radius, 2);
        }
        public override string ToString()
        {
            return "Круг. Радиус:" + radius + " Площадь:" + GetArea();
        }
        public void Print() { Console.WriteLine(ToString()); }

    }
}
