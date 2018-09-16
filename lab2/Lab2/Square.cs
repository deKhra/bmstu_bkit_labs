using System;

namespace Lab2
{
    class Square : Rectangle
    {
        public Square(double a) : base(a, a) { }
        public override string ToString()
        {
            return "Квадрат. Длина:" + a + " Площадь:" + GetArea();
        }
    }
}
