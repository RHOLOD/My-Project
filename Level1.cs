using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Level1Space
{
    public static class Level1
    {
        public static bool LineAnalysis(string line)
        {
            if (line.Length == 1)
            {
                return true;
            }
            bool proverka = false;
            int two = 0;
            for (int i = 1; i < line.Length; i++)
            {
                if (line[i] == '*')
                {
                    two = i;
                    break;
                }
            }
            string pat = line.Substring(1, two);
            int kol = two;
            if (kol == 0)
            {
                kol = 1;
            }
            for (int i = 1; i < line.Length - kol + 1; i += kol)
            {
                string str2 = line.Substring(i, kol);
                if (str2 == pat)
                {
                    proverka = true;
                }
                else
                {
                    proverka = false;
                }
            }

            return proverka;
        }
    }
}
