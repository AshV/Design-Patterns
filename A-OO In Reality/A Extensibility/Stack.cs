using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Extensibility
{
    class Stack : IStack
    {
        int IStack.pop()
        {
            throw new NotImplementedException();
        }

        void IStack.push(int x)
        {
            throw new NotImplementedException();
        }
    }
}
