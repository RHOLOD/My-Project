using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Level1Space
{
    public static class Level1
    {
        public static int[] SynchronizingTables(int N, int[] ids, int[] salary)
        {
            int[] nums = new int[N];
            int[] zap = new int[N];
            int[] nums1 = new int[N];
            int[] mas = new int[N];
            for (int i = 0; i < N; i++)
            {
                nums[i] = ids[i];
                zap[i] = salary[i];
                nums1[i] = ids[i];
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
            for (int i = 0; i < zap.Length - 1; i++)
            {
                for (int j = i + 1; j < zap.Length; j++)
                {
                    if (zap[i] > zap[j])
                    {
                        temp = zap[i];
                        zap[i] = zap[j];
                        zap[j] = temp;
                    }
                }
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (nums1[i] == nums[j])
                    {
                        mas[i] = zap[j];
                    }
                }
            }
            return mas;
        }
    }
}
