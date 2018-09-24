using System;

namespace Lab3
{
    class Rectangle : Figure, IPrint
    {
        public double width, height;
        public Rectangle(double a, double b) { this.width = a; this.height = b; }

        override public double GetArea()
        {
            return width * height;
        }

        public override string ToString()
        {
            return "Прямоугольник. Длина:" + height + " Ширина:" + width + " Площадь:" + GetArea();
        }
        public void Print() { Console.WriteLine(ToString()); }
    }
}
