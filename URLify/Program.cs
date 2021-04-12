using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IsUnique
{
    class Program
    {
        public string ConvertToURL(string s, int size)
        {
            string newString = new string("");

            for (int i = 0; i < size; i++)
            {
                if (s[i] == ' ')
                {
                    newString += "%20";
                }
                else
                {
                    newString += s[i].ToString();
                }
            }

            return newString;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            string sample = "Mr John Smith    ";

            Console.WriteLine(p.ConvertToURL(sample,13));
        }
    }
}
