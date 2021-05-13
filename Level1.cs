using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Level1Space
{
    public static class Level1
    {
        public static int MaximumDiscount(int N, int[] price)
        {
            int[] nums = new int[N];
            nums = price;
            int temp;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] < nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
            int k = N / 3;
            int ves = 0;
            for (int i = N - 1; i > N - k - 1; i--)
            {
                ves = ves + nums[i];
            }
            int ves2 = 0;
            for (int j = 1; j <= k; j++)
            {
                ves2 = ves2 + nums[j * 3 - 1];
            }
            return ves > ves2 ? ves : ves2;
        }
    }
}
