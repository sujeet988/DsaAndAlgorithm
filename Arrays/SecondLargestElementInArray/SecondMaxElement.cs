using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SecondLargestElementInArray
{
    public class SecondMaxElement
    {
        public static int SecoondLargetElement(int[] arr)
        {
            // There should be at least two elements
            if (arr.Length < 2)
            {
                return -1;
            }
            int maxElement = int.MinValue;
            int secondMaxElement = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                // If current element is greater
                // than maxElement then update both
                // maxElement and maxElement


                if (arr[i] > maxElement)
                {
                    secondMaxElement = maxElement;
                    maxElement = arr[i];
                }
                // If arr[i] is in between maxElement
                // and secondMaxElement then update secondMaxElement
                else if (arr[i] > secondMaxElement && arr[i] != maxElement)
                {
                    secondMaxElement = arr[i];
                }

            }

            //Handling worst case scenerio only need when execute on GFG OR leetcode
            if (secondMaxElement == int.MinValue)
            {
                return -1;
            }
            return secondMaxElement;
        }

        public static int SecoondLargetElement2(int[] arr)
        {
            // There should be at least two elements
            if (arr.Length < 2)
            {
                return -1;
            }
            int max = Int32.MinValue;
            int secondMax = Int32.MinValue;

            for (int i = 0; i < n; i++)
            {

                if (arr[i] > max)
                {

                    max = arr[i];
                }
            }

            for (int i = 0; i < n; i++)
            {

                if (arr[i] < max && arr[i] > secondMax)
                {

                    secondMax = arr[i];
                }
            }

            // If no second largest value then return -1
            if (secondMax == int.MinValue)
            {
                return -1;
            }


            return secondMax;

        }
    }
}
