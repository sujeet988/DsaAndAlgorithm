using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KthLowestElement
{
    internal class Kth
    {
        public int FindKthLowest(int[] nums, int k)
        {
            PriorityQueue<int, int> maxHeap = new PriorityQueue<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                    maxHeap.Enqueue(nums[i], nums[i]);
                if (maxHeap.Count > k)
                {
                    maxHeap.Dequeue();  
                }
            }
            return maxHeap.Peek();
        }
    }
}
