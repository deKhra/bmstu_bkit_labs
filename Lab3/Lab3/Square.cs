using System;

namespace Lab3
{
    class Square : Rectangle
    {
        public Square(double a) : base(a, a) { }
        public override string ToString()
        {
            return "Квадрат. Длина:" + width + " Площадь:" + GetArea();
        }
    }
}
