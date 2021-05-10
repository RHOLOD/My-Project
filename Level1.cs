using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Level1Space
{
    public static class Level1
    {
        public static int Unmanned(int L, int N, int[][] track)
        {
            int result = 0;
            int dlina = 0;

            for (int i = 0; i < N; i++)
            {
                int s = track[i][0];
                int k = track[i][1];
                int z = track[i][2];
                    if (s >= L)
                    {
                        return L;
                    }
                dlina = s - dlina;
                result = result + dlina;

                int octatoc = result % (k + z);

                if (result <= k)
                {
                    result = result + (k - result);
                }
                else if (octatoc <= k)
                {
                    result = result + octatoc;
                }
            }
            result = result + (L - track[N - 1][0]);

            return result;
        }
    }
}
