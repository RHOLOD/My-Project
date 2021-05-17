using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Level1Space
{
    public static class Level1
    {
        public static string[] ShopOLAP(int N, string[] items)
        {
            string[] massiv = new string[N];
            massiv = items;
            string[] massivStr = new string[N];
            int[] massivN = new int[N];


            for (int i = 0; i < N; i++)
            {
                string[] str = massiv[i].Split(' ');
                massivStr[i] = str[0];
                massivN[i] = int.Parse(str[1]);
            }
            int k = 0;
            int p = 0;
            for (int i = 0; i < N - 1; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    if (massivStr[i] == massivStr[j])
                    {
                        if (massivStr[i] != "null")
                        {
                            massivN[i] = massivN[i] + massivN[j];
                            massivStr[j] = "null";
                            k++;
                        }
                    }
                }
            }
            int M = 0;
            string[] massivNew = new string[N - k];
            int[] massivNewN = new int[N - k];
            for (int i = 0; i < N; i++)
            {
                if (massivStr[i] != "null")
                {
                    massivNew[M] = massivStr[i];
                    massivNewN[M] = massivN[i];
                    M++;
                }
            }

            int temp;
            string temps;
            for (int i = 0; i < M; i++)
            {
                for (int j = i + 1; j < M; j++)
                {
                    if (massivNewN[i] < massivNewN[j])
                    {
                        temp = massivNewN[i];
                        massivNewN[i] = massivNewN[j];
                        massivNewN[j] = temp;

                        temps = massivNew[i];
                        massivNew[i] = massivNew[j];
                        massivNew[j] = temps;
                    }
                }
            }

            int y = 0;
            int ju = 0;
            for (int i = 0; i < M; i++)
            {
                for (int j = i + 1; j < M; j++)
                {
                    if (massivNewN[i] == massivNewN[j])
                    {
                        y++;
                        ju = j;
                    }
                }
            }
            if (y > 0)
            {
                int r = 0;
                int[] indexi = new int[y + 1];
                for (int i = 0; i < M - 1; i++)
                {
                    if (massivNewN[i] == massivNewN[i + 1])
                    {
                        indexi[r] = i;
                        r++;
                    }
                }
                indexi[r] = ju;
                string[] leksi = new string[r + 1];
                for (int i = 0; i < r + 1; i++)
                {
                    leksi[i] = massivNew[indexi[i]];

                }
                Array.Sort(leksi);
                for (int i = 0; i < r + 1; i++)
                {
                    massivNew[indexi[i]] = leksi[i];

                }

            }
            for (int i = 0; i < M; i++)
            {
                massivNew[i] = massivNew[i] + " " + massivNewN[i].ToString();
            }
            return massivNew;
        }
    }
}
