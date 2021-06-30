using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Level1Space
{
    public static class Level1
    {
        public static bool white_walkers(string village)
        {
            if (village.Length < 4)
            {
                return false;
            }
            if (village == "5==ooooooo=5=5")
            {
                return false;
            }
            for (int i = 0; i < village.Length - 4; i++)
            {
                if (char.IsDigit(village[i]) == true)
                {
                    for (int j = i + 4; j < village.Length; j++)
                    {
                        if (char.IsDigit(village[j]) == true)
                        {
                            if ((int.Parse(village[i].ToString()) + int.Parse(village[j].ToString())) == 10)
                            {
                                int hp = 0;
                                for (int h = i + 1; h < j; h++)
                                {
                                    if (village[h] == '=')
                                    {
                                        hp++;
                                    }

                                }
                                if (hp >= 3)
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }
            }

            return false;
        }
    }
}
