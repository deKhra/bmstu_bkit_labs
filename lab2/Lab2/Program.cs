using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Square s = new Square(10);
            s.Print();

            Rectangle r = new Rectangle(1, 3);
            r.Print();
            Circle gf = new Circle(10);
            Console.WriteLine(gf.ToString());
            gf.Print();
            Console.ReadKey();
        }
    }
}
