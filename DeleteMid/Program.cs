using System;
using System.Collections.Generic;

namespace DeleteMid
{
    class Program
    {

        public LinkedList<int> DeleteMid(LinkedList<int> list)
        {
            LinkedListNode<int> cur = null;

            if (list == null)
            {
                //Throw error
            }
            else if (list.Count <= 2)
            {
                return list;
            }
            else if (list.Count == 3)
            {
                list.Remove(list.First.Next);
            }
            else
            {
                Random r = new Random();
                int random = r.Next(1, list.Count);
                cur = list.First;

                for (int i = 0; i < random; i++)
                {
                    cur = cur.Next;
                }

                list.Remove(cur);
            }

            return list;
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

            list.AddLast(5);
            list.AddLast(4);
            list.AddLast(1);
            list.AddLast(0);
            list.AddLast(2);
            list.AddLast(10);
            
            Console.Write("List = ");
            p.PrintList(list);
            Console.WriteLine();

            list = p.DeleteMid(list);

            Console.Write("New List = ");
            p.PrintList(list);
            Console.WriteLine();
            Console.WriteLine();

            list.Clear();
            list.AddLast(5);
            list.AddLast(4);
            list.AddLast(1);

            Console.Write("List = ");
            p.PrintList(list);
            Console.WriteLine();

            list = p.DeleteMid(list);

            Console.Write("New List = ");
            p.PrintList(list);
            Console.WriteLine();
            Console.WriteLine();

            list.Clear();
            list.AddLast(5);
            list.AddLast(1);

            Console.Write("List = ");
            p.PrintList(list);
            Console.WriteLine();

            list = p.DeleteMid(list);

            Console.Write("New List = ");
            p.PrintList(list);
            Console.WriteLine();
        }
    }
}
