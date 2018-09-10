using System;

namespace Lab2
{
    class Rectangle : Figure, IPrint
    {
        public double a, b;
        public Rectangle(double a, double b) { this.a = a; this.b = b; }

        override public double GetArea()
        {
            return a * b;
        }

        public override string ToString()
        {
            return "Прямоугольник. Длина:" + a + " Ширина:" + b + " Площадь:" + GetArea();
        }
        public void Print() { Console.WriteLine(ToString()); }
    }
}
