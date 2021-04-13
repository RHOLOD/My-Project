using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Level1Space
{
    public static class Level1
    {
        public static string PatternUnlock(int N, int[] hits)
        {
            int[] massiv = new int[N];
            for (int i = 0; i < N; i++)
            {
                massiv[i] = hits[i];
            }
            double a = Math.Sqrt(1.00 * 1.00 + 1.00 * 1.00);
            double b = 1.00000;
            double s = 0;
            for (int i = 1; i < N; i++)
            {
                if (massiv[i] == 2 && massiv[i - 1] == 9 || massiv[i] == 9 && massiv[i - 1] == 2) s = s + a;
                else if (massiv[i] == 2 && massiv[i - 1] == 7 || massiv[i] == 7 && massiv[i - 1] == 2) s = s + a;
                else if (massiv[i] == 2 && massiv[i - 1] == 4 || massiv[i] == 4 && massiv[i - 1] == 2) s = s + a;
                else if (massiv[i] == 2 && massiv[i - 1] == 6 || massiv[i] == 6 && massiv[i - 1] == 2) s = s + a;
                else if (massiv[i] == 5 && massiv[i - 1] == 1 || massiv[i] == 1 && massiv[i - 1] == 5) s = s + a;
                else if (massiv[i] == 5 && massiv[i - 1] == 3 || massiv[i] == 3 && massiv[i - 1] == 5) s = s + a;
                else if (massiv[i] == 8 && massiv[i - 1] == 1 || massiv[i] == 1 && massiv[i - 1] == 8) s = s + a;
                else if (massiv[i] == 8 && massiv[i - 1] == 3 || massiv[i] == 3 && massiv[i - 1] == 8) s = s + a;
                else s = s + b;
            }
            s = Math.Round(s, 5);
            string str = s.ToString();
            str = str.Replace(",", "");
            str = str.Replace("0", "");
            return str;
        }
    }
}
