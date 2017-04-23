using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Extensibility
{
    public interface IStack
    {
        void push(int x);
        int pop();
    }

    /* class IStack {
     * virtual void push(Integer x)=0;
     * virtual Integer pop()=0;
     * }
     */
}
