using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DsaAndAlgorithm.Heap.KthLowestElement
{
    internal class KthLowestElement
    {
        //max heap
        //time complexity : nlogk
        public int FindKthLowest(int[] nums, int k)
        {
            PriorityQueue<int, int> maxPriorityQueue = new PriorityQueue<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                maxPriorityQueue.Enqueue(nums[i], nums[i]);
                
            }

            // Dequeue the k-1 largest elements
            for (int i=0; i < k - 1; i++)
            {
                maxPriorityQueue.Dequeue();
            }
            // Return the kth lowest element
            return maxPriorityQueue.Dequeue();
        }

        ////Descending Order4 piority Queue
        /////Descending Sort, Integer

        public int FindKthLowestusingComparer(int[] nums, int k)
        {
            PriorityQueue<int, int> maxPriorityQueue = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y - x));

            for (var i = 0; i < nums.Length; i++)
            {
                maxPriorityQueue.Enqueue(nums[i], nums[i]);

                if (maxPriorityQueue.Count > k)
                {
                    maxPriorityQueue.Dequeue();
                }

            }

            // Return the kth lowest element
            return maxPriorityQueue.Peek();
        }
    }
}
