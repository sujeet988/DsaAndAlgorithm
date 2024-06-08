namespace FindKClosetElement
{

    /*
     * https://leetcode.com/problems/find-k-closest-elements/
     * Given a sorted integer array arr, two integers k and x, return the k closest integers to x in the array. The result should also be sorted in ascending order.

        An integer a is closer to x than an integer b if:

        |a - x| < |b - x|, or
        |a - x| == |b - x| and a < b
 

        Example 1:

        Input: arr = [1,2,3,4,5], k = 4, x = 3
        Output: [1,2,3,4]
        Example 2:

        Input: arr = [1,2,3,4,5], k = 4, x = -1
        Output: [1,2,3,4]

     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("find-k-closest-elements");
           int[] arr = new int[] { 1, 2, 3, 4, 9 };
            int k = 4, x = 3;

            //PriorityQueue<int,int> priorityQueue= new PriorityQueue<int,int>();
            PriorityQueue<int, int> priorityQueue = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y - x));

            foreach (var item in arr)
            {
                priorityQueue.Enqueue(item, Math.Abs(item - x));
                if (priorityQueue.Count> k)
                {
                    priorityQueue.Dequeue();

                }
            }

            List<int> list = new List<int>();
            while(priorityQueue.Count > 0)
            {
                list.Add(priorityQueue.Dequeue());
            }

            list.Sort();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}