using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Level1Space
{
    public static class Level1
    {
        public static void MatrixTurn(ref string[] Matrix, int M, int N, int T)
        {
            string[,] massiv = new string[M, N];
            string[,] massivE = new string[M, N];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    massiv[i, j] = Matrix[i][j].ToString();
                    massivE[i, j] = "0";
                }
            }
            int ko = 0;
            while (ko < T)
            {
                for (int G = 0; G < M / 2; G++)
                {
                    for (int l = 1 + G; l < N - G; l++)
                    {
                        massivE[0 + G, l] = massiv[0 + G, l - 1];
                    }
                    for (int l = N - 2 - G; l >= 0 + G; l--)
                    {
                        massivE[M - 1 - G, l] = massiv[M - 1 - G, l + 1];
                    }
                    for (int l = 1 + G; l < M - G; l++)
                    {
                        massivE[l, N - 1 - G] = massiv[l - 1, N - 1 - G];
                    }
                    for (int l = M - 2 - G; l >= 0 + G; l--)
                    {
                        massivE[l, 0 + G] = massiv[l + 1, 0 + G];
                    }
                }
                ko++;
                for (int i = 0; i < M; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        massiv[i, j] = massivE[i, j];
                    }
                }
            }


            string[] massivK = new string[M];
            for (int k = 0; k < M; k++)
            {
                string ki = "";
                for (int j = 0; j < N; j++)
                {
                    ki += massivE[k, j].ToString();
                }
                massivK[k] = ki;
            }
            for (int i = 0; i < M; i++)
            {
                Matrix[i] = massivK[i];
            }
        }
    }
}
