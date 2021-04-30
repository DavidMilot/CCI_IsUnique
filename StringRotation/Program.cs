using System;

namespace StringRotation
{
    class Program
    {
        public bool isSubString(string s1, string s2)
        {
            int i = 0;
            int j = 0;
            int count = 0;

            if (s1 == null || s2 == null)
            {
                //Throw exception
            }

            if (s1.Length == 0 || s2.Length == 0 || s1.Length != s2.Length)
            {
                return false;
            }

            while (i < s1.Length)
            {
                if (s1[i] != s2[j])
                {
                    j++;
                    count++;
                }
                else
                {
                    i++;
                    j++;
                }

                if (count == s2.Length)
                {
                    return false;
                }

                if (j == s2.Length)
                {
                    j = 0;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            string s1 = "waterbottle";
            string s2 = "erbottlewat";

            Console.WriteLine(s1 + " " + s2);
            Console.WriteLine(p.isSubString(s1,s2).ToString());
            
            s1 = "abcdddabc";
            s2 = "qabcabcdd";
            Console.WriteLine(s1 + " " + s2);
            Console.WriteLine(p.isSubString(s1, s2).ToString());
            s1 = "abcdddabc";
            s2 = "dabcabcdd";
            Console.WriteLine(s1 + " " + s2);
            Console.WriteLine(p.isSubString(s1, s2).ToString());
            s1 = "abcd";
            s2 = "abef";
            Console.WriteLine(s1 + " " + s2);
            Console.WriteLine(p.isSubString(s1, s2).ToString());
        }
    }
}
