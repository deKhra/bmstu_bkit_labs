using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class ReadLines
    {
        Console.
 
        string tempStrTrim = ""; 
        //Список строк 
        List<string> list = new List<string>(); 
        do {     
            //Временная переменная для хранения строки     
            string tempStr = Console.ReadLine();     
            //Удаление пробелов из введенной строки     
            tempStrTrim = tempStr.Trim();     
            if (tempStrTrim != ""){         
                //Непустая строка сохраняется в список         
                list.Add(tempStrTrim);     
            } 
        } while (tempStrTrim != ""); 
    }
}
