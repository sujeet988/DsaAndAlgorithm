using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KthLowestElement
{
    internal class Kth
    {
        public int FindKthLargest(int[] nums, int k)
        {
            PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>();
            foreach (var item in nums)
            {
                minHeap.Enqueue(item, item);
                if (minHeap.Count > k)
                {
                    minHeap.Dequeue();
                }
            }
            return minHeap.Peek();
        }

        public int FindKthLowest(int[] nums, int k)
        {
            PriorityQueue<int, int> maxPriorityQueue = new PriorityQueue<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                maxPriorityQueue.Enqueue(nums[i], nums[i]);

            }

            // Dequeue the k-1 largest elements
            for (int i = 0; i < k - 1; i++)
            {
                maxPriorityQueue.Dequeue();
            }
            // Return the kth lowest element
            return maxPriorityQueue.Dequeue();
        }
    }
}
