using DsaAndAlgorithm.Heap.KthLargestElement;

Console.WriteLine("kth-largest-element-in-an-array");

/*
 *  * https://leetcode.com/problems/kth-largest-element-in-an-array/description/
 * Given an integer array nums and an integer k, return the kth largest element in the array.
   Note that it is the kth largest element in the sorted order, not the kth distinct element.
   You must solve it in O(n) time complexity.

 * Input: nums = [3,2,1,5,6,4], k = 2
    Output: 5
  *Input: nums = [3,2,3,1,2,4,5,5,6], k = 4
    Output: 4
 */

int[] nums = new int[] { 7, 10, 4, 3, 20, 15 };
int k = 3;

int ouput= KthLargestElement.FindKthLargest(nums, k);
Console.WriteLine("Kth largest element is " + ouput); //// 10;
Console.ReadLine(); 
