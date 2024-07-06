using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ArrayisSortedOrNot
{
    internal class ArrayIsSortedOrNot
    {
        ////https://www.geeksforgeeks.org/program-check-array-sorted-not-iterative-recursive//
        ///https://leetcode.com/problems/check-if-array-is-sorted-and-rotated/description/
        public static bool IsSortedByIterativeApproach(int[] arr)
        {
            //Time Complexity: O(n) i.e., n is length of array / number of element is array
            //Auxiliary Space: O(1)
            if (arr.Length == 0 || arr.Length==1)
            {
                return false;
            }

            for(int i=1; i < arr.Length; i++)
            {
                if(arr[i - 1] > arr[i])
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Check array is sorted or not by stack
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>

        public static bool IsSortedByStackApproach(int[] arr)
        {
            //Time Complexity: O(n) i.e., n is length of array / number of element is array
            //Auxiliary Space: O(1)
             Stack<int> stack = new Stack<int>();
            if (arr.Length == 0 || arr.Length == 1)
            {
                return false;
            }

            for (int i = 1; i < arr.Length; i++)
            {
                if (stack.Count == 0)
                {
                    stack.Push(arr[i]);
                }
                else
                {
                    int top=stack.Peek();
                    if (arr[i] < top) // IT shoud be greater than previos element
                    {
                        return false;
                    }
                    else
                    {
                        stack.Push(arr[i]);
                    }
                }
            }
            return true;
        }
    }
}
