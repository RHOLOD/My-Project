using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zadachka1
{
    class Program
    {
        static void Main(string[] args)
        {

            int squirrel(int N)
            {
                int a = 1;
                for (int i = 1; i <= N; i++)
                {
                    a = a * (int) i;
                }
                if (a > 10)
                {
                    string s = a.ToString();
                    s = s.Remove(1);
                    a = Convert.ToInt32(s);
                }

                return a;
            }

        }
        
    }
}
