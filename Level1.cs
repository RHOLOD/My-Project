using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Level1Space
{
    public static class Level1
    {
        public static int[] WordSearch(int len, string s, string subs)
        {
            string stoka = s;
            string[] massivStr = new string[1000];
            int n = 0;
            int m = stoka.Length;
            do
            {
                int index = 0;
                for (int i = len - 1; i >= 0; i--)
                {
                    if (stoka[i] == ' ')
                    {
                        index = i;
                        break;
                    }
                }
                if (index == 0) index = len;
                string text = stoka.Substring(0, index);
                massivStr[n] = text;
                n++;
                stoka = stoka.Remove(0, index + 1);
                m = stoka.Length;
                if (m <= 12)
                {
                    massivStr[n] = stoka;
                    n++;
                    break;
                }
            }
            while (m > 1);
            int[] masun = new int[n];
            int numb = subs.Length;
            for (int j = 0; j < n; j++)
            {
                int lo = massivStr[j].IndexOf(subs);
                if (lo == 0)
                {
                    if (massivStr[j][numb] == ' ')
                        masun[j] = 1;
                }
                else masun[j] = 0;
            }
            return masun;
        }
    }
}
