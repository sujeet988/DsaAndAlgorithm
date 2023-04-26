using System;
using System.Collections.Generic;

namespace ProductOfArrayExceptSelf
{
    /*
     * leetcode : 238 https://leetcode.com/problems/product-of-array-except-self/
     * https://www.youtube.com/watch?v=UBkpyXgx0g0&t=423s
     * Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].
     * Input: nums = [1,2,3,4]
        Output: [24,12,8,6]
     */
    internal class Program
    {

        //Brute  force
        //Space complexity o(n)
        // time complexity o(n^2)
        // For long input this may TLE (TIME limit excedded)
        public static int[] ProductExceptSelf(int[] nums)
        {
            int[] result= new int[nums.Length];
            List<int> list= new List<int>();
            for(int i=0; i < nums.Length; i++)
            {
                list.Add(nums[i]);
            }
           
            for(int i=0; i < list.Count; i++)
            {
                int multiply = 1;
                for (int j=0; j < nums.Length; j++)
                {
                    if (i!=j)
                    {
                        multiply = multiply * nums[j];
                    }
                }
                result[i]= multiply;
            }

            return result;

        }

        // Time complexity : o(n)
        public static int[] ProductExceptSelfByOptimized(int[] nums)
        {

            int product = 1;
            //right product array
            int[] right=new int[nums.Length];
            for (int i = nums.Length-1; i >=0;i--)
            {
                product = product * nums[i];
                right[i]= product;
            }
            //make result with maintaint with left prodcut
            product = 1;
            int[] result=new int[nums.Length];
            for (int i=0; i < nums.Length - 1; i++)
            {
                int lp = product; // lp left product
                int rp = right[i+1]; // rp right product
                result[i] = lp * rp;
                product *= nums[i];
            }

            result[nums.Length-1]= product;

            return result;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Product of Array Except Self");
            int[] nums = new int[] { 1,2,3,4 };
            int[] output = null;
            //Brute force
            output = ProductExceptSelf(nums); //[24,12,8,6]
            foreach (var item in output)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine("Product of Array Except Self By Optimized");
            output = ProductExceptSelfByOptimized(nums); //[24,12,8,6]
            foreach (var item in output)
            {
                Console.WriteLine(item + " ");
            }
            Console.ReadLine(); 
            
        }
    }
}
