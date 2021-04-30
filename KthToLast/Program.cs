using System;
using System.Collections;
using System.Collections.Generic;

namespace KthToLast
{
    class Program
    {

        public int GetKthToLast(LinkedList<int> list, int k)
        {
            int offset = list.Count - k;
            LinkedListNode<int> cur = null;

            if (k < 0)
            {
                //Throw error
            }

            if (list == null)
            {
                //Throw error
            }

            if (k > list.Count)
            {
                //Throw error
            }

            offset = list.Count - k;
            cur = list.First;

            for (int i = 0; i < offset; i++)
            {
                cur = cur.Next;
            }

            return cur.Value;
        }

        void PrintList(LinkedList<int> list)
        {
            foreach (int data in list)
            {
                Console.Write(data + " ");
            }
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            LinkedList<int> list = new LinkedList<int>();
            int element = -1;
            int k = 3;

            list.AddLast(5);
            list.AddLast(4);
            list.AddLast(8);
            list.AddLast(1);
            list.AddLast(0);
            list.AddLast(2);
            list.AddLast(10);

            Console.Write("Remove kth element = " + k + " List = ");
            p.PrintList(list);
            Console.WriteLine();

            element = p.GetKthToLast(list,k);

            Console.Write("Element found = " + element);
        }
    }
}
