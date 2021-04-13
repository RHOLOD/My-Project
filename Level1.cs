using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Level1Space
{
    public static class Level1
    {
        public static int ConquestCampaign(int N, int M, int L, int[] battalion)
        {
            int[,] contry = new int[N, M];
            int[] number = new int[4] { 2, 2, 3, 4 };
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    contry[i, j] = 0;
                }
            }
            for (int k = 1; k < L * 2 + 1; k += 2)
            {
                contry[battalion[k - 1] - 1, battalion[k] - 1] = 2;
            }

            int a = 0;
            int day = 1;

            while (true)
            {
                int h = 1;
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < M; j++)
                    {
                        if (contry[i, j] == 1)
                        {
                            contry[i, j] = 2;
                        }

                    }
                }
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < M; j++)
                    {
                        h = h * contry[i, j];
                    }
                }
                if (h == 0)
                {
                    for (int i = 0; i < N; i++)
                    {
                        for (int j = 0; j < M; j++)
                        {
                            if (contry[i, j] == 2)
                            {
                                try
                                {
                                    if (contry[i + 1, j] != 2)
                                    {
                                        contry[i + 1, j] = 1;
                                    }

                                }
                                catch
                                {

                                }
                                try
                                {
                                    if (contry[i - 1, j] != 2)
                                    {
                                        contry[i - 1, j] = 1;
                                    }
                                }
                                catch
                                {

                                }
                                try
                                {
                                    if (contry[i, j + 1] != 2)
                                    {
                                        contry[i, j + 1] = 1;
                                    }
                                }
                                catch
                                {

                                }
                                try
                                {
                                    if (contry[i, j - 1] != 2)
                                    {
                                        contry[i, j - 1] = 1;
                                    }
                                }
                                catch
                                {

                                }

                            }
                        }
                    }
                    day += 1;
                }
                else
                {
                    break;
                }

            }
            return day;
        }
    }
}
