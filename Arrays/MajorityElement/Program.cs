using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

namespace MajorityElement
{
    internal class Program
    {
        /*
         * https://leetcode.com/problems/majority-element/
         * https://practice.geeksforgeeks.org/problems/majority-element-1587115620/1?utm_source=youtube&utm_medium=collab_striver_ytdescription&utm_campaign=majority-element
         * The majority element is the element that appears more than n / 2 times.
         * 
         */
        public static int majorityElement(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                int count = 0;
                for (int j = 0; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }
                if (count > (n / 2))
                {
                    return arr[i];
                }
            }

            return -1;

        }
        //Time Complexity: O(N2), where N = size of the given array.
        //Reason: For every element of the array the inner loop runs for N times. And there are N elements in the array. So, the total time complexity is O(N2).
        //Space Complexity: O(1) as we use no extra space.

        public static int majorityElementOptimzed(int[] arr)
        {
            int n = arr.Length;
            Dictionary<int, int> obj = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {

                if (obj.ContainsKey(arr[i]))
                {
                    obj[arr[i]]++;
                }
                else
                {
                    obj.Add(arr[i], 1);

                }
            }
            foreach (KeyValuePair<int, int> item in obj)
            {
                if (item.Value > (n / 2))
                {
                    return item.Key;
                }

            }


            return -1;
        }
        //Time Complexity: O(N* logN) + O(N), where N = size of the given array.
        //Reason: We are using a map data structure.Insertion in the map takes logN time.And we are doing it for N elements.So, it results in the first term O(N* logN). The second O(N) is for checking which element occurs more than floor(N/2) times.If we use unordered_map instead, the first term will be O(N) for the best and average case and for the worst case, it will be O(N2).
        //Space Complexity: O(N) as we are using a map data structure.

        static void Main(string[] args)
        {
            Console.WriteLine("Majority Elements");
            int[] arr = { 2, 2, 1, 1, 1, 2, 2 };

            //By Brue Force
            int ans = majorityElement(arr);
            Console.WriteLine("The majority element is: " + ans);
            //By Optimized approach
             ans = majorityElementOptimzed(arr);
            Console.WriteLine("The majority element by Optimzed approach  is: " + ans);
            Console.ReadLine();
        }
    }
}
