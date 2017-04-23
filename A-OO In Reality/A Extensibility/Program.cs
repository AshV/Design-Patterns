using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Extensibility
{
    class Program
    {
        // since stack implementations could change, we are hiding all the stack implementations behind IStack interface
        // class level encapsulation
        // the ideas in 00-paradigm that supports calss level encapsulation are: inheritance, polymorphism, dynamics binding
        public static void testStack(IStack stack)
        {
            stack.push(10);
            stack.push(20);
            Console.WriteLine(stack.pop());
        }

        static void Main(string[] args)
        {
        }
    }
}
