using System;
using System.Collections;
using System.Collections.Generic;

namespace CrackingTheCodingInterview
{
    class Program
    {
        bool IsUnique(string stringCheck)
        {
            Dictionary<char, int> dictionaryChar = new Dictionary<char, int>();

            for (int i = 0; i < stringCheck.Length; i++)
            {
                if (dictionaryChar.ContainsKey(stringCheck[i]))
                {
                    Console.WriteLine(dictionaryChar.Count);
                    return false;
                }
                else
                {
                    dictionaryChar.Add(stringCheck[i],i);
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            string sample = "Hello";

            Console.WriteLine(p.IsUnique(sample).ToString());
        }
    }
}
