using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Level1Space
{
    public static class Level1
    {
        public static string BiggerGreater(string input)
        {
            string str = "";
            int istr = input.Length;
            bool flag = true;
            int d = 0;
            for (int i = 0; i < istr; i++)
            {

                if (input[0] == input[i])
                {
                    d++;
                }
                if (d == istr)
                {
                    return "";
                }
            }

            string[] massiv = new string[istr];
            for (int i = 0; i < istr; i++)
            {
                massiv[i] = input[i].ToString();
            }
            int h = 0;
            while (flag)
            {
                h++;
                for (int i = istr - 1; i > 0; i--)
                {
                    string a = massiv[i];
                    string b = massiv[i - 1];
                    massiv[i] = b;
                    massiv[i - 1] = a;
                    str = "";
                    for (int j = 0; j < istr; j++)
                    {
                        str += massiv[j].ToString();
                    }
                    int result = String.Compare(input, str);
                    if (result < 0)
                    {
                        flag = false;
                        break;
                    }
                }
                if (h > 300)
                {
                    str = "";
                    break;

                }
            }
            return str;
        }

    }
}
