using System;
using System.Collections;

namespace StringCompression
{
    class Program
    {
        public string compressString(string rawString)
        {
            string compressedString = new string("");

            if (rawString == null)
            {
                return null;
            }
            else if (rawString.Length <= 2)
            {
                return rawString;
            }
            else
            {
                int charCount = 0;
                char lastChar = ' ';

                lastChar = rawString[0];
                compressedString += lastChar;

                for (int i = 0; i < rawString.Length; i++)
                {
                    if (rawString[i] == lastChar)
                    {
                        charCount++;
                    }
                    else
                    {
                        lastChar = rawString[i];
                        compressedString += charCount.ToString() + lastChar;
                        charCount = 1;
                    }

                    if (i == rawString.Length - 1)
                    {
                        compressedString += charCount.ToString();
                    }
                }
            }

            if (compressedString.Length < rawString.Length)
            {
                Console.Write(" --- STRING COMPRESSED --- ");
                return compressedString;
            }

            return rawString;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            string s = "aabcccccaab";

            Console.WriteLine("String to compress " + s + " = " + p.compressString(s));

            s = "aa";

            Console.WriteLine("String to compress " + s + " = " + p.compressString(s));

            s = "e";

            Console.WriteLine("String to compress " + s + " = " + p.compressString(s));

            s = "abcdefghi";

            Console.WriteLine("String to compress " + s + " = " + p.compressString(s));

            s = "aaaaeee";

            Console.WriteLine("String to compress " + s + " = " + p.compressString(s));
        }
    }
}
