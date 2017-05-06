using System.Collections.Generic;

namespace J_Solution_1
{
    public class LinkedStack : LinkedList<int>, IStack
    {
        public IEnumerator<int> iterator()
        {
            return GetEnumerator();
        }

        public int? pop()
        {
            if (Count == 0)
                return null;
            int value = First.Value;
            RemoveFirst();
            return value;
        }

        public void push(int e)
        {
            AddFirst(e);
        }

        public int size()
        {
            return Count;
        }
    }
}