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
            int naumbe = s.Length;
            int nou = naumbe / len + 100;
            string[] massivStr = new string[nou];
            int n = 0;
            int m = stoka.Length;
            do
            {
                m = stoka.Length;
                if (m <= len)
                {
                    massivStr[n] = stoka + " ";
                    n++;
                    break;
                }
                int index = 0;
                for (int i = len - 1; i >= 0; i--)
                {
                    if (stoka[i] == ' ')
                    {
                        index = i;
                        break;
                    }
                }
                if (index == 0)
                {
                    int pop = 0;
                    for (int k = 0; k < m; k++)
                    {
                        if (stoka[k] == ' ')
                        {
                            pop = 1;
                        }
                    }
                    if (pop == 1)
                    {
                        index = len;
                        string textt = stoka.Substring(0, index);
                        massivStr[n] = textt + " ";
                        n++;
                        stoka = stoka.Remove(0, index + 1);
                    }

                    index = len;
                    string text = stoka.Substring(0, index);
                    massivStr[n] = text + " ";
                    n++;
                    stoka = stoka.Remove(0, index);
                }
                else
                {
                    string text = stoka.Substring(0, index);
                    massivStr[n] = text + " ";
                    n++;
                    stoka = stoka.Remove(0, index + 1);
                }
            }
            while (m > 1);
            int[] masun = new int[n];
            int numb = subs.Length;
            string moo = subs;
            for (int j = 0; j < n; j++)
            {
                int lo = massivStr[j].IndexOf(moo);
                if (lo >= 0)
                {
                    if ((massivStr[j][lo + numb] == ' ') || (massivStr[j][lo + numb] == '.'))
                    {
                        masun[j] = 1;
                    }
                }
                else masun[j] = 0;
            }
            return masun;
        }
    }
}
