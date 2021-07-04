using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Level1Space
{
    public static class Level1
    {
        public static bool Football(int[] F, int N)
        {

            bool bolk = true;
            for (int i = 1; i < N; i++)
            {
                if (F[i] <= F[i - 1])
                {
                    bolk = false;
                }
            }
            if (bolk == true)
            {
                return true;
            }
            else
            {

                for (int i = 0; i < N - 1; i++)
                {
                    for (int j = i + 1; j < N; j++)
                    {
                        bool bil = true;
                        int jm = F[j];
                        int im = F[i];
                        int[] massiv = new int[N];
                        for (int o = 0; o < N; o++)
                        {
                            massiv[o] = F[o];
                        }
                        massiv[i] = jm;
                        massiv[j] = im;
                        for (int p = 1; p < N; p++)
                        {
                            if (massiv[p] <= massiv[p - 1])
                            {
                                bil = false;
                            }
                        }
                        if (bil == true)
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
        }
    }
}
