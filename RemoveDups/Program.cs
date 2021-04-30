using System;
using System.Collections.Generic;
using System.Collections;

namespace RemoveDups
{
    class Program
    {
        public LinkedList<int> RemoveDups(LinkedList<int> list)
        {
            HashSet<int> hash = new HashSet<int>();

            if (list == null)
            {
                
            }

            if (list.Count == 0 || list.Count == 1)
            {
                return list;
            }

            foreach (int item in list)
            {
                if (hash.Count == 0)
                {
                    hash.Add(item);
                }
                else
                {
                    if (!hash.Contains(item))
                    {
                        hash.Add(item);
                    }
                }
            }

            if (list.Count == hash.Count)
            {
                return list;
            }

            LinkedList<int> newList = new LinkedList<int>();

            foreach (int item in hash)
            {
                newList.AddLast(item);
            }

            return newList;
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
            list.AddLast(2);
            list.AddLast(8);
            list.AddLast(9);
            list.AddLast(8);
            list.AddLast(1);
            list.AddLast(0);
            list.AddLast(2);
            list.AddLast(10);

            Console.Write("List = ");
            p.PrintList(list);
            Console.WriteLine();

            list = p.RemoveDups(list);

            Console.Write("No Dups List = ");
            p.PrintList(list);
            Console.WriteLine();

            list.Clear();
            list.AddLast(5);
            list.AddLast(2);
            list.AddLast(8);
            list.AddLast(9);

            Console.Write("List = ");
            p.PrintList(list);

            list = p.RemoveDups(list);

            Console.WriteLine();
            Console.Write("No Dups List = ");
            p.PrintList(list);
            Console.WriteLine();

            list.Clear();
            list.AddLast(1);
            list.AddLast(1);
            list.AddLast(1);
            list.AddLast(1);

            Console.Write("List = ");
            p.PrintList(list);

            list = p.RemoveDups(list);

            Console.WriteLine();
            Console.Write("No Dups List = ");
            p.PrintList(list);

        }
    }
}
