using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;

namespace InterSectionOfTwoUnSortedArrays
{

    /*
 *  Find the intersection of two sorted arrays. OR in other words, Given 2 sorted arrays, find all the elements which occur in both the arrays.
 *  Input: 
A: [1 2 3 3 4 5 6]
, B: [3 3 5]
Output: 3,3,5
Explanation: We are given two arrays A and B. 
The elements present in both the arrays  
are 3,3 and 5.
    https://leetcode.com/problems/intersection-of-two-arrays/
    https://practice.geeksforgeeks.org/problems/intersection-of-two-arrays2404/1?utm_source=gfg&utm_medium=article&utm_campaign=bottom_sticky_on_article
 */

    internal class Program
    {
        //Hash set approach
        public static int[] Intersection(int[] nums1, int[] nums2)
        {
            HashSet<int> set = new HashSet<int>();
            foreach (int num in nums1)
                set.Add(num);

            HashSet<int> res = new HashSet<int>();
            foreach (int num in nums2)
            {
                if (set.Contains(num))
                    res.Add(num);
            }
            return res.ToArray();


        }
        static void Main(string[] args)
        {
            Console.WriteLine("InterSection of un Sorted Arrays");

            Console.WriteLine("HashSet approach");
            int[] nums1 = new int[] { 1, 2, 2, 1 };
            int[] nums2 = new int[] { 2, 2 };

            int[] output = null;
            output = Intersection(nums1, nums2);
            foreach (var item in output)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("Two pointer approach");
            Console.ReadLine();
        }
    }
}
