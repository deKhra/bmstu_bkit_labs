using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass test = new TestClass("Это сообщение выведется при вызове метода Message.");
            Type t = typeof(TestClass);

            Console.WriteLine("\nКонструкторы:");
            foreach (var x in t.GetConstructors())
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\nМетоды:");
            foreach (var x in t.GetMethods())
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\nСвойства:");
            foreach (var x in t.GetProperties())
            {
                Console.WriteLine(x);
            }
            //выделение атирибутов
            Console.WriteLine("\nСвойства с атрибутами:");
            foreach (var x in t.GetProperties())
            {
                if (x.GetCustomAttributes(typeof(CustomAttribute),false).Length > 0) Console.WriteLine(x.Name);
            }

            t.InvokeMember("Message", BindingFlags.InvokeMethod, null, test, new object[] {10});

            Console.Read();

        }
    }
}
