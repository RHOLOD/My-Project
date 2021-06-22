using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Level1Space
{
    public static class Level1
    {
        public static bool TransformTransform(int[] A, int N)
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N - i; j++)
                {
                    int k = i + j;
                    if (i == 0)
                    {
                        numbers.Add(A[j]);
                    }
                    else if (j == N - 1)
                    {
                        numbers.Add(A[j]);
                    }
                    else if (k > N - 1)
                    {
                        int max = 0;
                        for (int p = j; p < N; p++)
                        {
                            if (A[p] > max)
                            {
                                max = A[p];
                            }
                        }
                        numbers.Add(max);
                    }
                    else
                    {
                        int max = 0;
                        for (int p = j; p <= k; p++)
                        {
                            if (A[p] > max)
                            {
                                max = A[p];
                            }
                        }
                        numbers.Add(max);
                    }
                }
            }
            int M = numbers.Count;
            List<int> numbers2 = new List<int>();
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < M - i; j++)
                {
                    int k = i + j;
                    if (i == 0)
                    {
                        numbers2.Add(numbers[j]);
                    }
                    else if (j == M - 1)
                    {
                        numbers2.Add(numbers[j]);
                    }
                    else if (k > M - 1)
                    {
                        int max = 0;
                        for (int p = j; p < M; p++)
                        {
                            if (numbers[p] > max)
                            {
                                max = numbers[p];
                            }
                        }
                        numbers2.Add(max);
                    }
                    else
                    {
                        int max = 0;
                        for (int p = j; p <= k; p++)
                        {
                            if (numbers[p] > max)
                            {
                                max = numbers[p];
                            }
                        }
                        numbers2.Add(max);
                    }
                }
            }
            int mex = numbers2.Count;
            int sum = 0;
            for (int r = 0; r < mex; r++)
            {
                sum += numbers2[r];
            }

            bool b = false;
            if (sum % 2 == 0)
            {
                b = true;
            }
            else
            {
                b = false;
            }
            return b;
        }
    }
}
