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
            PriorityQueue<int, int> queue = new PriorityQueue<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                if (queue.Count < k)
                    queue.Enqueue(nums[i], nums[i]);
                else
                {
                    if (nums[i] <= queue.Peek()) continue;

                    queue.Dequeue();
                    queue.Enqueue(nums[i], nums[i]);
                }
            }
            return queue.Dequeue();
        }

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
