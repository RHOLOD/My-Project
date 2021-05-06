using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Level1Space
{
    public static class Level1
    {
        public static int[] UFO(int N, int[] data, bool octal)
        {
            int[] massiv = new int[N];
            if (octal == false)
            {
                for (int i = 0; i < N; i++)
                {
                    string Oct = data[i].ToString();
                    ulong temp = Convert.ToUInt64(Oct, 16);
                    massiv[i] = (int)temp;
                }
            }
            else if (octal == true)
            {
                for (int i = 0; i < N; i++)
                {
                    string Oct = data[i].ToString();
                    ulong temp = Convert.ToUInt64(Oct, 8);
                    massiv[i] = (int)temp;
                }
            }
            return massiv;
        }
    }
}
