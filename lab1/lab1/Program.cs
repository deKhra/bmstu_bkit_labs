using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.Write("Введите коэффициент a: ");
            while (double.TryParse(Console.ReadLine(), out a) == false || a==0)
            {
                Console.WriteLine("Ошибка. Повторите ввод.");
            }
            Console.Write("Введите коэффициент b: ");
            while (double.TryParse(Console.ReadLine(), out b) == false)
            {
                Console.WriteLine("Ошибка. Повторите ввод.");
            }
            Console.Write("Введите коэффициент c: ");
            while (double.TryParse(Console.ReadLine(), out c) == false)
            {
                Console.WriteLine("Ошибка. Повторите ввод.");
            }
            Console.WriteLine("Введено уравнение: {0}*x^2+{1}*x+{2}=0", a, b, c);
            double D = Math.Pow(b, 2) - 4 * a * c;
            if (D > 0)
            {
                double x1 = (-b - Math.Sqrt(D)) / (2 * a);
                double x2 = (-b + Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("Корни: {0}, {1}", x1, x2);
            }
            else if (D == 0)
            {
                double x1 = -b / (2 * a);
                Console.WriteLine("Корень: {0}", x1);
            }
            else Console.WriteLine("Нет корней");
            Console.ReadKey();
        }
    }
}
