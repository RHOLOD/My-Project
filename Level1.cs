using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Level1Space
{
    public static class Level1
    {
        public static int[] MadMax(int N, int[] Tele)
        {
            int[] nums = new int[N];
            for (int i = 0; i < N; i++)
            {
                nums[i] = Tele[i];
            }
            int temp;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }

            int max = nums[0];
            for (int i = 0; i < N; i++)
            {
                if (nums[i] > max)
                    max = nums[i];
            }
            int p = N / 2;
            int[] gig = new int[p + 1];
            int g = 0;
            for (int i = N - 1; i >= p; i--)
            {
                gig[g] = nums[i];
                g++;
            }
            int l = 0;
            for (int i = p; i < N; i++)
            {
                nums[i] = gig[l];
                l++;
            }
            return nums;
        }
    }
}
