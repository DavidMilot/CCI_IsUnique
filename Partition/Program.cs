using System;
using System.Collections;
using System.Collections.Generic;

namespace Partition
{
    class Program
    {
        public LinkedList<int> Partition(LinkedList<int> list, int part)
        {
            LinkedList<int> left = new LinkedList<int>();
            LinkedList<int> right = new LinkedList<int>();

            foreach (int element in list)
            {
                if (element < part)
                {
                    left.AddFirst(element);
                }
                else
                {
                    right.AddFirst(element);
                }
            }

            //Combine all right elements to the left LinkedList
            foreach (int element in right)
            {
                left.AddLast(element);
            }

            return left;
        }

        public void PrintList(LinkedList<int> list)
        {
            foreach (int data in list)
            {
                Console.Write(data + " ");
            }
        }

        static void Main(string[] args)
        {
            Program p = new Program();

            LinkedList<int> inputList = new LinkedList<int>();
            inputList.AddFirst(3);
            inputList.AddFirst(5);
            inputList.AddFirst(8);
            inputList.AddFirst(5);
            inputList.AddFirst(10);
            inputList.AddFirst(2);
            inputList.AddFirst(1);

            p.PrintList(inputList);

            Console.WriteLine();

            LinkedList<int> newList = p.Partition(inputList, 5);

            p.PrintList(newList);
        }
    }
}
