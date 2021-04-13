using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
        public static int odometer(int[] oksana)
        {
            int s = 0;
            int l = oksana.Length;
            for (int i = 0; i < l; i += 2)
            {
                s = s + oksana[i];
            }

            return s;
        }
    }
}