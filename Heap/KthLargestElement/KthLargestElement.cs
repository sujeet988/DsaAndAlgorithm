using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsaAndAlgorithm.Heap.KthLargestElement
{
    public class KthLargestElement
    {
        public static int FindKthLargest(int[] nums, int k)
        {
            PriorityQueue<int,int> minHeap= new PriorityQueue<int,int>();
            foreach(var item in nums)
            {
                minHeap.Enqueue(item, item);
                if (minHeap.Count > k)
                {
                    minHeap.Dequeue();
                }
            }
            return minHeap.Peek();
        }

    }

}
