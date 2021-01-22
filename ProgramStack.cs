using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UdemyStackCS
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            stack.Push("1");
            stack.Push('2');
            stack.Push("3");
            stack.Push("4");
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Thread.Sleep(60000);
        }
    }

    class Stack
    {
         List<object> stackCollection=new List<object>();

        public void Push(object obj)
        {
            if (obj == null)
            {
                throw new InvalidOperationException();
            }
            stackCollection.Add(obj);              
        }
        public object Pop()
        {
            if(stackCollection.Count==0)
                throw new InvalidOperationException();
            object objnew= stackCollection.ElementAt(stackCollection.Count-1);
            stackCollection.RemoveAt(stackCollection.Count-1);
            return objnew;
        }
        void Clear()
        {
            stackCollection.Clear();
        }

    }
}
