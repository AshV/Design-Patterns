using System.Collections;
using System.Collections.Generic;

namespace J_Solution_1
{
    public interface IStack
    {
        void push(int e);
        int? pop();
        IEnumerator<int> iterator();
        int size();
    }
}