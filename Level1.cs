using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Level1Space
{
    public static class Level1
    {
        public static bool TankRush(int H1, int W1, string S1, int H2, int W2, string S2)
        {
            int[,] massiv1 = new int[H1, W1];
            int[,] massiv2 = new int[H2, W2];

            string[] mas1 = S1.Split(' ');
            string[] mas2 = S2.Split(' ');


            for (int i = 0; i < H1; i++)
            {
                for (int j = 0; j < W1; j++)
                {
                    massiv1[i, j] = int.Parse(mas1[i][j].ToString());
                }
            }
            for (int i = 0; i < H2; i++)
            {
                for (int j = 0; j < W2; j++)
                {
                    massiv2[i, j] = int.Parse(mas2[i][j].ToString());
                }
            }
            int a = H1 - H2;
            int b = W1 - W2;
            int n = 0;
            for (int m = 0; m <= b; m++)
            {
                for (int i = 0; i <= a; i++)
                {
                    for (int j = 0; j < H2; j++)
                    {
                        for (int k = 0; k < W2; k++)
                        {
                            if (massiv1[j + i, k + m] == massiv2[j, k])
                            {
                                n++;
                            }
                        }
                    }
                    if (n == H2 * W2)
                    {
                        return true;
                    }
                    n = 0;
                }
            }
            return false;
        }
    }
}
