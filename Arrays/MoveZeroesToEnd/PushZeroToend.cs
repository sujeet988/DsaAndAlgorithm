using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsAlgo.Sujeet
{
    internal class PushZeroToend
    {
        //Naive Solution or Brute Force Solution

        public static int[] PushZeroToEnd(int[] arr)
        {
            /*
             * Time complexity: o(n) Space complexity: o(n)
             */
            int n = arr.Length;
            int[] newarr = new int[n];
            int k = 0;

            for (int i = 0; i < n; i++)
            {

                if (arr[i] != 0)
                {
                    newarr[k] = arr[i];
                    k++;
                }
            }

            if (k < n)
            {
                newarr[k] = 0;
                k++;
            }

            return newarr;

        }
        //By Two pointer
        // Optmized
        public static int[]  PushZeroToEndByTwoPointer(int[] nums)
        {
            //Do not return anything, modify nums in-place instead.
            int l = 0;
            for (int r = 0; r < nums.Length; r++)
            {
                if (nums[r] != 0)
                {
                    int tmp = nums[l];
                    nums[l] = nums[r];
                    nums[r] = tmp;
                    l += 1;
                }
            }
            return nums;
        }

    }

}
