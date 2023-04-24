using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopKFrequeentElement
{
    internal class TopKFreqElementsdata
    {

        public static int[] TopKFreuentElement(int[] nums, int k)
        {
            int[] arr = new int[k];
            Dictionary<int, int> freq = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int key = nums[i];

                if (freq.ContainsKey(nums[i]))
                {
                    freq[key]++;
                }
                else
                {
                    freq.Add(nums[i], 1);
                }
            }
            int count = 0;
            foreach (KeyValuePair<int, int> data in freq)
            {

                if (count == k)
                {

                    break;
                }
                arr[count] = data.Key;
                count++;
            }
            return arr;
        }
    }
}
