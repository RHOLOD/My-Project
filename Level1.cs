using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Level1Space
{
    public static class Level1
    {
        public static string BigMinus(string s1, string s2)
        {
            string st1 = "";
            string st2 = "";
            int n1 = 0;
            int n2 = 0;

            int a = int.Parse(s1);
            int b = int.Parse(s2);

            if (a >= b)
            {
                st1 = s1;
                st2 = s2;
                n1 = st1.Length;
                n2 = st2.Length;
            }
            else if (a < b)
            {
                st1 = s2;
                st2 = s1;
                n1 = st1.Length;
                n2 = st2.Length;
            }

            int[] massiv2 = new int[n2];
            int[] massiv3 = new int[n1];

            for (int i = 0; i < n2; i++)
            {
                massiv2[i] = int.Parse(st2[i].ToString());
            }
            for (int i = 0; i < n1; i++)
            {
                massiv3[i] = int.Parse(st1[i].ToString());
            }
            int k = n1 - 1;
            for (int j = n2 - 1; j >= 0; j--)
            {

                if ((massiv3[k] - massiv2[j]) < 0)
                {
                    massiv3[k] = massiv3[k] - massiv2[j] + 10;
                    int l = k - 1;

                    if (massiv3[l] == 0)
                    {
                        while (massiv3[l] == 0)
                        {
                            massiv3[l] = 9;
                            if (massiv3[l - 1] == 0)
                            {
                                l--;
                            }
                            else
                            {
                                massiv3[l - 1] = massiv3[l - 1] - 1;
                                break;
                            }
                        }
                    }
                    else
                    {
                        massiv3[l] = massiv3[l] - 1;
                    }
                }
                else
                {
                    massiv3[k] = massiv3[k] - massiv2[j];
                }
                k--;
            }
            string stok = "";
            for (int i = 0; i < n1; i++)
            {
                stok += massiv3[i].ToString();
            }
            int lol = int.Parse(stok);
            stok = lol.ToString();
            return stok;
        }
    }
}
