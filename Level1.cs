using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Level1Space
{
    public static class Level1
    {
        public static bool MisterRobot(int N, int[] data)
        {
            int[] massiv = new int[N];
            int[] mus = new int[3] { 0, 0, 0 };
            massiv = data;
            bool low = false;
            if (ProverkaSort(N, data) == true)
            {
                return true;
            }
            while (low == false)
            {
                if (ProverkaSort(N, data) == true)
                {
                    return true;
                }
                for (int i = 0; i < N - 3; i++)
                {
                    int k = 0;
                    while (massiv[i] > massiv[i + 1] || massiv[i + 1] > massiv[i + 2])
                    {
                        if (k > 3)
                        {
                            return false;
                        }
                        mus = Massiv3(massiv[i], massiv[i + 1], massiv[i + 2]);
                        massiv[i] = mus[0];
                        massiv[i + 1] = mus[1];
                        massiv[i + 2] = mus[2];
                        k++;
                    }
                }
            }
            return false;
        }
        static int[] Massiv3(int a, int b, int c)
        {
            int a1 = a;
            int b1 = b;
            int c1 = c;
            int m = 0;

            m = a1;
            a1 = b1;
            b1 = c1;
            c1 = m;
            int[] massivchik = new int[3] { a1, b1, c1 };
            return massivchik;
        }
        static bool ProverkaSort(int N, int[] massiv)
        {
            bool sorted = true;
            for (int i = 0; i < N - 1; i++)
            {
                if (massiv[i] > massiv[i + 1])
                {
                    sorted = false;
                    break;
                }
            }
            return sorted;
        }
    }
}
