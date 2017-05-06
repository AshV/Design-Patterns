using System.Collections.Generic;

namespace J_Solution_2
{
    public class LinkedStack : IStack
    {
        private LinkedList<int> list;

        public LinkedStack()
        {
            list = new LinkedList<int>();
        }

        public IEnumerator<int> iterator()
        {
            return list.GetEnumerator();
        }

        public int? pop()
        {
            if (list.Count == 0)
                return null;
            int value = list.First.Value;
            list.RemoveFirst();
            return value;
        }

        public void push(int e)
        {
            list.AddFirst(e);
        }

        public int size()
        {
            return list.Count;
        }
    }
}
