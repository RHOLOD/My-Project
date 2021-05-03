using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Level1Space
{
    public static class Level1
    {
        public static string MassVote(int N, int[] Votes)
        {
            double[] massivP = new double[N];
            int sto = 0;
            for (int i = 0; i < N; i++)
            {
                sto += Votes[i];
            }
            for (int i = 0; i < N; i++)
            {
                massivP[i] = Math.Round((double)Votes[i] / (double)sto, 3);
            }

            int nom = 1;
            double max = massivP[0];
            for (int i = 0; i < N; i++)
            {
                if (massivP[i] > max)
                {
                    max = massivP[i];
                    nom = i + 1;
                }
            }
            bool kol = false;
            int nk = 0;
            for (int i = 0; i < N; i++)
            {
                if (massivP[i] == max)
                {
                    nk++;
                }
            }
            if (nk > 1)
            {
                kol = true;
            }
            string mmm = "";
            if (kol == true)
            {
                mmm = "no winner";
            }
            else
            {
                mmm = "majority winner " + nom.ToString();
            }
            return mmm;
        }
    }
}
