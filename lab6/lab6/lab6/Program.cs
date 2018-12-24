using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{

    delegate void Compare(int a, int b);

    class Program
    {

        static void MyCompare(int i1,int i2)
        {
            if (i1 > i2) Console.WriteLine(i1+" greater than "+i2);
            else if (i2 > i1) Console.WriteLine(i2 + " greater than " + i1);
            else Console.WriteLine(i1+" and "+i2+" are equal");
        }
        static void MyRusCompare(int i1, int i2)
        {
            if (i1 > i2) Console.WriteLine(i1 + " больше, чем " + i2);
            else if (i2 > i1) Console.WriteLine(i2 + " больше, чем " + i1);
            else Console.WriteLine(i1 + " и " + i2 + " равны");
        }
        static int MyAnotherCompare(int i1, int i2)
        {
            if (i1 > i2) return 1;
            else if (i2 > i1) return -1;
            else return 0;
        }

        static void Comparator(int x, int y, Compare Comparete) 
        {
            Comparete(x, y);
        }
        static void ComparatorAction(int x, int y, Action<int, int> Comparete)
        {
            Comparete(x, y);
        }
        static void ComparatorFunc(int x, int y, Func<int,int,int> Comparete)
        {
            switch (Comparete(x, y)) 
            {
                case 1:
                    Console.WriteLine("{0} больше {1}", x, y);
                    break;
                case -1:
                    Console.WriteLine("{1} больше {0}", x, y);
                    break;
                case 0:
                    Console.WriteLine("{0} равен {1}", x, y);
                    break;
            } 
        }




        static void Main(string[] args)
        {
            Comparator(10, 20, MyCompare);
            Comparator(10, 20, MyRusCompare);
            Comparator(10, 20, (x, y) =>
                {
                    Console.WriteLine("Сравниваемые числа:" + x + " и " + y);
                    {
                    }
                }
            );
            ComparatorAction(10, 20, MyCompare);
            ComparatorFunc(10, 20, MyAnotherCompare);
            Console.Read();
        }
    }
}
