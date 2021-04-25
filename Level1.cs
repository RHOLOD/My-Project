using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Level1Space
{
    public static class Level1
    {
        public static string TheRabbitsFoot(string s, bool encode)
        {
            if (encode == true)
            {
                string strk = s.Replace(" ", "");
                int n = strk.Length;
                double sq = Math.Round(Math.Sqrt(n), 2);
                int a = (int)sq;
                int b = ((int)(sq * 10)) % 10;
                while (a * b < n)
                {
                    a++;
                }

                string[] stroki = new string[a];
                for (int i = 0; i < a; i++)
                {
                    int non = strk.Length;
                    if (non < b)
                    {
                        for (int g = 0; g < (b - non); g++)
                        {
                            strk = strk + " ";
                        }
                        stroki[i] = strk;
                        break;
                    }
                    else
                    {
                        stroki[i] = strk.Substring(0, b);
                        strk = strk.Remove(0, b);

                    }
                }
                string rezult = "";
                for (int j = 0; j < b; j++)
                {
                    string hoh = "";
                    for (int l = 0; l < a; l++)
                    {
                        if (stroki[l][j] != ' ')
                        {
                            hoh = hoh + stroki[l][j].ToString();
                        }
                    }
                    if (j == b - 1)
                    {
                        rezult = rezult + hoh;
                    }
                    else
                    {
                        rezult = rezult + hoh + " ";
                    }
                }
                return rezult;
            }
            else if (encode == false)
            {
                string[] strlist = s.Split(' ');
                int ni = strlist.Length;
                int ny = strlist[0].Length;

                string rezult2 = "";
                for (int e = 0; e < ny; e++)
                {
                    string him = "";
                    if (e == ny - 1)
                    {
                        for (int r = 0; r < ni; r++)
                        {
                            try
                            {
                                him = him + strlist[r][e];
                            }
                            catch
                            {
                                break;
                            }
                        }

                    }
                    else
                    {
                        for (int r = 0; r < ni; r++)
                        {
                            him = him + strlist[r][e];

                        }
                    }
                    rezult2 = rezult2 + him;
                }
                return rezult2;
            }
            return "";
        }
    }
}
