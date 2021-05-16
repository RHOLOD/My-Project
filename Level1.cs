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
            if (k == 0)
            {
                int temp;
                string temps;
                for (int i = 0; i < N; i++)
                {
                    for (int j = i + 1; j < N; j++)
                    {
                        if (massivN[i] < massivN[j])
                        {
                            temp = massivN[i];
                            massivN[i] = massivN[j];
                            massivN[j] = temp;

                            temps = massivStr[i];
                            massivStr[i] = massivStr[j];
                            massivStr[j] = temps;
                        }
                    }
                }
                for (int i = 0; i < N; i++)
                {
                    massivStr[i] = massivStr[i] + " " + massivN[i].ToString();
                }
                return massivStr;
            }
            else
            {
                int M = 0;
                string[] massivNew = new string[N - k];
                for (int i = 0; i < N; i++)
                {
                    if (massivStr[i] != "null")
                    {
                        massivNew[M] = massivStr[i] + " " + massivN[i].ToString();
                        M++;
                    }
                }
                Array.Sort(massivNew);

                return massivNew;
            }

        }
    }
}
