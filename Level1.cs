using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LevelSpace
{
    public static class Level1
    {
        public static int odometer(int[] oksana)
        {
            int s = 0;
            int l = oksana.Length;
            for (int i = 1; i < l; i += 2)
            {
                s = s + oksana[i] * oksana[i - 1];
            }

            return s;
        }
    }
}
