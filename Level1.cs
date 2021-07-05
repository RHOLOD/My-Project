using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Level1Space
{
    public static class Level1
    {
        public static string Keymaker(int k)
        {
            int[] massiv = new int[k];
            for (int i = 0; i < k; i++)
            {
                massiv[i] = 1;
            }

            for (int i = 2; i <= k; i++)
            {
                int j = k / i;
                for (int l = 1; l <= j; l++)
                {
                    if (massiv[l * i - 1] == 0)
                    {
                        massiv[l * i - 1] = 1;
                    }
                    else
                    {
                        massiv[l * i - 1] = 0;
                    }
                }
            }
            string str = "";
            for (int i = 0; i < k; i++)
            {
                str += massiv[i].ToString();
            }

            return str;
        }
    }
}
