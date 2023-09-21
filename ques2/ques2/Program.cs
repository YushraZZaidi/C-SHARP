using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "yes";
            string ss = "seyyy";
            char[] s1 = s.ToCharArray();
            char[] s2 = ss.ToCharArray();
            Array.Sort(s1);
            Array.Sort(s2);
            bool res = check(s1, s2);
            Console.WriteLine(res);
            Console.ReadLine();


        }
        static bool check(char[] s1, char[] s2)
        {
            if (s1.Length != s2.Length)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < s1.Length; i++)
                {
                    if (s1[i] != s2[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}