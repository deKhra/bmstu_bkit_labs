using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class SimpleStack<T>: SimpleList<T> where T:IComparable
    {
        public void Push(T obj) 
        {
            Add(obj);
        }
        public T Pop() 
        {
            T Result = default(T);
            if (this.Count == 0) { return Result;}
            if (this.Count == 1) 
            { 
                return this.first.data;
                this.first = null;
                this.last = null;
                this.Count--;
            }
            else
            {
                Result = this.last.data;
                GetItem(this.Count - 2).next = null;
                this.last = GetItem(this.Count - 2);
                this.Count--;
                return Result;
 
            }

            
                    
        
        
        
        }
    }
}
