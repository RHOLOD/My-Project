using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Level1Space
{
    public static class Level1
    {
        public static int SumOfThe(int N, int[] data)
        {
            int[] massiv = new int[N];
            massiv = data;
            int rezult = 0;
            for (int i = 0; i < N; i++)
            {
                int nil = 0;
                for (int j = 0; j < N; j++)
                {
                    nil = nil + massiv[j];
                }
                nil = nil - massiv[i];
                if (nil == massiv[i])
                {
                    rezult = massiv[i];
                    break;
                }
            }

            return rezult;
        }
    }
}
