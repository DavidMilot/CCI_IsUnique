using System;
using System.Text;

namespace OneAway
{
    class Program
    {

        public bool isOneAway(string start, string goal)
        {
            if (start == null || goal == null)
            {
                //Throw exception here
            }

            if (Math.Abs(start.Length - goal.Length) >= 2)
            {
                return false;
            }
            
            if (start.Length == goal.Length)
            {
                return replaceCheck(start, goal);
            }
            
            if (start.Length - goal.Length == 1)
            {
                return removeCheck(start, goal);
            }

            if (start.Length - goal.Length == -1)
            {
                return insertCheck(start, goal);
            }

            return false;
        }

        bool insertCheck(string start, string goal)
        {
            int mismatch = 0;
            int i = 0;
            int j = 0;
            while (i < start.Length)
            {
                if (start[i] == goal[j])
                {
                    i++;
                    j++;
                }
                else if (start[i] != goal[j])
                {
                    j++;
                    mismatch++;
                }
                if (mismatch == 2) 
                    return false;
            }
            return true;
        }

        bool removeCheck(string start, string goal)
        {
            int mismatch = 0;
            int i = 0;
            int j = 0;
            while (j < start.Length)
            {
                if (start[i] == goal[j])
                {
                    i++;
                    j++;
                }
                else if (start[i] != goal[j])
                {
                    i++;
                    mismatch++;
                }
                if (mismatch == 2)
                    return false;
            }
            return true;
        }

        bool replaceCheck(string start, string goal)
        {
            int mismatch = 0;
            int i = 0;
            int j = 0;
            while (i < start.Length)
            {
                if (start[i] == goal[j])
                {
                    i++;
                    j++;
                }
                else if (start[i] != goal[j])
                {
                    i++;
                    j++;
                    mismatch++;
                }
                if (mismatch == 2)
                    return false;
            }
            return true;
        }


        static void Main(string[] args)
        {
            Program p = new Program();
            string a = "";
            string b = "";

            /*
            Console.WriteLine("Is string " + a +" and string " + b + " one away? = " + p.isOneAway(a,b).ToString());

            a = "pales";
            b = "pale";

            Console.WriteLine("Is string " + a + " and string " + b + " one away? = " + p.isOneAway(a, b).ToString());
            */
            a = "abc";
            b = "abcd";

            Console.WriteLine("Is string " + a + " and string " + b + " one away? = " + p.isOneAway(a, b).ToString());

            a = "a";
            b = "bb";

            Console.WriteLine("Is string " + a + " and string " + b + " one away? = " + p.isOneAway(a, b).ToString());

            a = "acd";
            b = "abcd";

            Console.WriteLine("Is string " + a + " and string " + b + " one away? = " + p.isOneAway(a, b).ToString());

        }
    }
}
