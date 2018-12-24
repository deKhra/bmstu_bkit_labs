using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class TestClass
    {
        public TestClass() { }
        public TestClass(string msg) { str = msg; }
        public int number { get { return _number; } set { _number = value; } }

        private int _number;
        
        public string str { get; set; }
        [CustomAttribute]
        public string property1{get; set;}

        public string property2 { get; set; }

        [CustomAttribute]
        public string property3 { get; set; }

        public string property4 { get; set; }

        [CustomAttribute]
        public string property5 { get; set; }
        
        public string property6 { get; set; }
        public void Message(int i) 
        {
            Console.WriteLine(str +" Введено значение "+ i);
        }
    }
}
