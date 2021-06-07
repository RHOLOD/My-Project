using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Level1Space
{
    public static class Level1
    {
        public static string[] TreeOfLife(int H, int W, int N, string[] tree)
        {
            string[] massiv = tree;
            string[,] misis = new string[H, W];
            int n = 0;
            for (int i = 0; i < H; i++)
            {
                string str = massiv[i];
                str = str.Replace("+", "1");
                massiv[i] = str;
            }

            while (n < N)
            {
                int flag = 0;
                for (int i = 0; i < H; i++)
                {
                    string str = massiv[i];
                    str = str.Replace("5", "6");
                    str = str.Replace("4", "5");
                    str = str.Replace("3", "4");
                    str = str.Replace("2", "3");
                    str = str.Replace("1", "2");
                    str = str.Replace(".", "1");
                    massiv[i] = str;
                }
                n++;
                for (int i = 0; i < H; i++)
                {
                    for (int j = 0; j < W; j++)
                    {
                        if (massiv[i][j] == '3' || massiv[i][j] == '4' || massiv[i][j] == '5' || massiv[i][j] == '6')
                        {
                            flag = 1;
                        }
                    }
                }
                if (flag == 1)
                {
                    if (n % 2 == 0)
                    {

                        for (int i = 0; i < H; i++)
                        {
                            for (int j = 0; j < W; j++)
                            {
                                misis[i, j] = massiv[i][j].ToString();
                            }
                        }
                        for (int i = 0; i < H; i++)
                        {
                            for (int j = 0; j < W; j++)
                            {
                                if (misis[i, j] == "3" || misis[i, j] == "4" || misis[i, j] == "5" || misis[i, j] == "6")
                                {
                                    try
                                    {
                                        if (misis[i, j - 1] != "3" && misis[i, j - 1] != "4" && misis[i, j - 1] != "5" && misis[i, j - 1] != "6")
                                        {
                                            misis[i, j - 1] = ".";
                                        }

                                    }
                                    catch { }
                                    try
                                    {
                                        if (misis[i, j + 1] != "3" && misis[i, j + 1] != "4" && misis[i, j + 1] != "5" && misis[i, j + 1] != "6")
                                        {
                                            misis[i, j + 1] = ".";
                                        }

                                    }
                                    catch { }
                                    try
                                    {
                                        if (misis[i - 1, j] != "3" && misis[i - 1, j] != "4" && misis[i - 1, j] != "5" && misis[i - 1, j] != "6")
                                        {
                                            misis[i - 1, j] = ".";
                                        }

                                    }
                                    catch { }
                                    try
                                    {
                                        if (misis[i + 1, j] != "3" && misis[i + 1, j] != "4" && misis[i + 1, j] != "5" && misis[i + 1, j] != "6")
                                        {
                                            misis[i + 1, j] = ".";
                                        }

                                    }
                                    catch { }
                                    misis[i, j] = ".";
                                }
                            }
                        }
                        for (int i = 0; i < H; i++)
                        {
                            string gig = "";
                            for (int j = 0; j < W; j++)
                            {
                                gig += misis[i, j].ToString();
                            }
                            massiv[i] = gig;
                        }
                    }
                }
            }
            for (int i = 0; i < H; i++)
            {
                string gig = "";
                for (int j = 0; j < W; j++)
                {
                    if (misis[i, j] != ".")
                    {
                        gig += "+";
                    }
                    else
                    {
                        gig += ".";
                    }
                }
                massiv[i] = gig;
            }
            return massiv;
        }
    }
}
