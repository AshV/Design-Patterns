using System.Collections.Generic;

namespace J_Solution_2
{
    public interface IStack
    {
        void push(int e);
        int? pop();
        IEnumerator<int> iterator();
        int size();
    }
}