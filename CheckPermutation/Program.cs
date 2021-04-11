using System;
using System.Collections;
using System.Collections.Generic;

namespace CheckPermutation
{
    class Program
    {
        bool isPermutation(string s1, string s2)
        {
            Dictionary<char,int> stringDict = new Dictionary<char,int>();

            if (s1.Length != s2.Length || s1 == null || s2 == null)
            {
                return false;
            }

            //Add all characters from the same length string for S1 and S2 into the dictionary
            for (int i = 0; i < s1.Length; i++)
            {
                //If it does not exist in the Dictionary, add it and set counter to 1
                if (!stringDict.ContainsKey(s1[i]))
                {
                    stringDict.Add(s1[i], 1);
                }
                else
                {
                    //If dictionary already containts key, find the paired key/value and increment the value by 1
                    stringDict[s1[i]]++;
                }

                //If it does not exist in the Dictionary, add it and set counter to 1
                if (!stringDict.ContainsKey(s2[i]))
                {
                    stringDict.Add(s2[i], 1);
                }
                else
                {
                    //If dictionary already containts key, find the paired key/value and increment the value by 1
                    stringDict[s2[i]]++;
                }
            }

            //If there are an even number of characters in the dictionary, there is no permutation
            foreach (KeyValuePair<char, int> entry in stringDict)
            {
                if (entry.Value % 2 != 0)
                {
                    return false;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            string a = "apple";
            string b = "ppael";

            Console.WriteLine("String a = " + a);
            Console.WriteLine("String b = " + b);
            Console.WriteLine("Are these strings a permutation of each other? = " + p.isPermutation(a, b));

            a = "apple";
            b = "ppppe";

            Console.WriteLine("String a = " + a);
            Console.WriteLine("String b = " + b);
            Console.WriteLine("Are these strings a permutation of each other? = " + p.isPermutation(a, b));

            a = "ball";
            b = "balls";
            Console.WriteLine("String a = " + a);
            Console.WriteLine("String b = " + b);
            Console.WriteLine("Are these strings a permutation of each other? = " + p.isPermutation(a, b));

            a = "shirt";
            b = "hostr";
            Console.WriteLine("String a = " + a);
            Console.WriteLine("String b = " + b);
            Console.WriteLine("Are these strings a permutation of each other? = " + p.isPermutation(a, b));

        }
    }
}
