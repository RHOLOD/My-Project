using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Level1Space
{
    public static class Level1
    {
        public static bool SherlockValidString(string s)
        {
            if (s == "")
            {
                return false;
            }
            int lp = s.Length;
            string sty = "";
            bool jo = false;
            jo = Valid(s);
            if (jo == true)
            {
                return jo;
            }
            else
            {
                for (int i = 0; i < lp; i++)
                {

                    sty = s.Substring(0, i) + s.Substring(i + 1);
                    jo = Valid(sty);
                    if (jo == true)
                    {
                        break;
                    }
                }
            }
            return jo;
        }

        public static bool Valid(string st)
        {
            int k = 0;
            string line = "";
            int len = st.Length;
            for (int i = 0; i < len; i++)
            {
                string kis = "";
                for (int j = 0; j < len; j++)
                {
                    if (st[i] == st[j])
                    {
                        kis += st[j].ToString();
                    }
                }
                line += " " + kis;
                k++;
            }
            string[] str = line.Split();
            int n = str.Length;
            bool b = false;
            for (int i = 1; i < n; i++)
            {
                if (str[1].Length == str[i].Length)
                {
                    b = true;
                }
                else
                {
                    b = false;
                    break;
                }
            }
            return b;
        }
    }
}
