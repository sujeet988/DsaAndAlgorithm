using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

namespace _3SumArrays
{
    /*
     * Problem Statement: Given an array of N integers, your task is to find unique triplets that add up to give a sum of zero. In short, you need to return an array of all the unique triplets [arr[a], arr[b], arr[c]] such that i!=j, j!=k, k!=i, and their sum is equal to zero.
     * Input: nums = [-1,0,1,2,-1,-4]
       Output: [[-1,-1,2],[-1,0,1]]
      Explanation: Out of all possible unique triplets possible, [-1,-1,2] and [-1,0,1] satisfy the condition of summing up to zero with i!=j!=k
     */
    internal class Program
    {
        

       // https://www.youtube.com/watch?v=lxzJxiZtv8U

        // Brute Force
        //Approach1: We keep three-pointers i,j, and k. For every triplet we find the sum of A[i]+A[j]+A[k]. If this sum is equal to zero, we’ve found one of the triplets. We add it to our data structure and continue with the rest.
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> outputlist = new List<IList<int>>();
            HashSet<string> visited = new HashSet<string>();// only for remove duplicate
            //if (nums.Length < 3) //edge cases
            //{
            //    return outputlist;
            //}
            int i, j, k;
            int n = nums.Length;
            for (i = 0; i < nums.Length; i++)
            {
                for (j = i + 1; j < nums.Length; j++)
                {
                    for (k = j + 1; k < nums.Length; k++)
                    {
                        List<int> temp = new List<int>();
                        if (nums[i] + nums[j] + nums[k] == 0 )
                        {

                           
                                temp.Add(nums[i]);
                                temp.Add(nums[j]);
                                temp.Add(nums[k]);
                                temp.Sort();
                              String str = temp[0] + ":" + temp[1] + ":" + temp[2];// duplicate check
                            if (!visited.Contains(str))
                            {
                                outputlist.Add(temp);
                                visited.Add(str);
                            }
                                
                            

                        }

                    }

                }
            }

            return outputlist;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("3 sum");
            int[] nums = new int[] { -1, 0, 1, 2, -1, -4 };
            //Brute Force
            Console.WriteLine("3 sum using 3 loops");
            var output = ThreeSum(nums);
            foreach (var list in output)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Console.Write(list[i] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
