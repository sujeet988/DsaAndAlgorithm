using System;

namespace DsaAndAlgorithm.TwoPointer.TwoSumII_InputArrayIsSorted
{
    /*
     * Two Sum II - Input Array Is Sorted
     * https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
     * Input: numbers = [2,7,11,15], target = 9
     * Output: [1,2]
        Explanation: The sum of 2 and 7 is 9. Therefore, 
        index1 = 1, index2 = 2. We return [1, 2]

     Input: numbers = [-1,0], target = -1
     Output: [1,2]
     Explanation: The sum of -1 and 0 is -1. 
     Therefore index1 = 1, index2 = 2. We return [1, 2].
     */
    internal class Program
    {

        public static int[] TwoSum(int[] numbers, int target)
        {
            int[] arr = new int[2];
            int start = 0;
            int end = numbers.Length - 1;

            while (start < end)
            {
                int sum = numbers[start] + numbers[end];
                if (sum > target)
                {
                    end--;
                }
                if (sum < target)
                {
                    start++;
                }
                if (sum == target)
                {

                    arr[0] = start ;
                     arr[1] = end ;

                    ////arr[0] = start + 1; //increment by one if indexed start from 1, if mentioned in questioned
                    ////arr[1] = end + 1;  //increment by one if indexed start from 1, if mentioned in questioned
                    return arr;
                }
            }

            return arr;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Two Sum II - Input Array Is Sorted");
            int[] numbers = new int[] { 2, 7, 11, 15 };
            int target = 9;
            var output= TwoSum(numbers, target); // ouput array : [0 , 1]
            foreach(var item in output) 
            { Console.Write(item+" "); 
            }
            //output : 0 1

            Console.ReadLine();
        }
    }
}
