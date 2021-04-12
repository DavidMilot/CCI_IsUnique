using System;
using System.Collections;
using System.Collections.Generic;

namespace PalidromePermutation
{
    class Program
    {
        public bool isPalidromePermu(string s)
        {

            Dictionary<char, int> paliDict = new Dictionary<char, int>();

            if (s == null)
            {
                //Throw exception
            }

            //Edge cases
            if (s.Length == 0)
            {
                return false;
            }
            else if (s.Length == 1)
            {
                return true;
            }
            else if (s.Length == 2)
            {
                if (s[0] == s[1])
                {
                    return true;
                }
            }
            else if (s.Length == 3)
            {
                if (s[0] == s[1] || s[0] == s[2])
                {
                    return true;
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
                //char not found in dictionary
                if (!paliDict.ContainsKey(s[i]))
                {
                    paliDict.Add(s[i], 1);
                }
                else
                {
                    //Increment the counter in the pair/value
                    paliDict[s[i]]++;
                }
            }

            //Even length
            if (s.Length % 2 == 0)
            {
                //If there are an even number of characters in the dictionary, there is no permutation
                foreach (KeyValuePair<char, int> entry in paliDict)
                {
                    if (entry.Value % 2 != 0)
                    {
                        return false;
                    }
                }
            }
            //Odd length
            else
            {
                int totalCount = 0;

                //If there are an even number of characters in the dictionary, there is no permutation
                foreach (KeyValuePair<char, int> entry in paliDict)
                {
                    totalCount += entry.Value;
                }

                if (totalCount % 2 == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            Program p = new Program();

            Console.WriteLine("--- EDGE CASES ---");

            string a = "wwo";

            Console.WriteLine("String = " + a);
            Console.WriteLine("Is this string a permutation of a palidrome? = " + p.isPalidromePermu(a));

            a = "rr";

            Console.WriteLine("String = " + a);
            Console.WriteLine("Is this string a permutation of a palidrome? = " + p.isPalidromePermu(a));

            a = "ew";

            Console.WriteLine("String = " + a);
            Console.WriteLine("Is this string a permutation of a palidrome? = " + p.isPalidromePermu(a));

            a = "a";

            Console.WriteLine("String = " + a);
            Console.WriteLine("Is this string a permutation of a palidrome? = " + p.isPalidromePermu(a));

            Console.WriteLine("--- EVEN STRING LENGTH ---");

            a = "pppp";

            Console.WriteLine("String = " + a);
            Console.WriteLine("Is this string a permutation of a palidrome? = " + p.isPalidromePermu(a));

            a = "nnoo";

            Console.WriteLine("String = " + a);
            Console.WriteLine("Is this string a permutation of a palidrome? = " + p.isPalidromePermu(a));

            a = "paul";

            Console.WriteLine("String = " + a);
            Console.WriteLine("Is this string a permutation of a palidrome? = " + p.isPalidromePermu(a));

            a = "aabbccll";

            Console.WriteLine("String = " + a);
            Console.WriteLine("Is this string a permutation of a palidrome? = " + p.isPalidromePermu(a));

            a = "racecar";

            Console.WriteLine("String = " + a);
            Console.WriteLine("Is this string a permutation of a palidrome? = " + p.isPalidromePermu(a));

            a = "aabbcccc";

            Console.WriteLine("String = " + a);
            Console.WriteLine("Is this string a permutation of a palidrome? = " + p.isPalidromePermu(a));

            a = "aaacbcaa";

            Console.WriteLine("String = " + a);
            Console.WriteLine("Is this string a permutation of a palidrome? = " + p.isPalidromePermu(a));

            a = "zzzrzzzz";

            Console.WriteLine("String = " + a);
            Console.WriteLine("Is this string a permutation of a palidrome? = " + p.isPalidromePermu(a));

            Console.WriteLine("--- ODD STRING LENGTH ---");

            //Odd
            a = "teeeeee";

            Console.WriteLine("String = " + a);
            Console.WriteLine("Is this string a permutation of a palidrome? = " + p.isPalidromePermu(a));

            a = "civci";

            Console.WriteLine("String = " + a);
            Console.WriteLine("Is this string a permutation of a palidrome? = " + p.isPalidromePermu(a));

            a = "HHHHH";

            Console.WriteLine("String = " + a);
            Console.WriteLine("Is this string a permutation of a palidrome? = " + p.isPalidromePermu(a));

            a = "eafae";

            Console.WriteLine("String = " + a);
            Console.WriteLine("Is this string a permutation of a palidrome? = " + p.isPalidromePermu(a));

            a = "effae";

            Console.WriteLine("String = " + a);
            Console.WriteLine("Is this string a permutation of a palidrome? = " + p.isPalidromePermu(a));
        }
    }
}
