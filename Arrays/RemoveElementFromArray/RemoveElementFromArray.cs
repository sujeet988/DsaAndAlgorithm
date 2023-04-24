using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  DsAgo.Sujeet
{
    internal class RemoveElementFromArray
    {
        public static int[] removeTheElement(int[] arr, int index)
        { // If the array is empty
          // or the index is not in array range
          // return the original array
            if (arr == null || index < 0
                || index >= arr.Length)
            {

                return arr;
            }

            // Create another array of size one less
            int[] anotherArray = new int[arr.Length - 1];

            // Copy the elements except the index
            // from original array to the other array
            for (int i = 0, k = 0; i < arr.Length; i++)
            {

                // if the index is
                // the removal element index
                if (i == index)
                {
                    continue;
                }

                // if the index is not
                // the removal element index
                anotherArray[k++] = arr[i];
            }

            // return the resultant array
            return anotherArray;
        }
        public static int[] removeTheElementUsingList(int[] arr, int index)
        { // If the array is empty
          // or the index is not in array range
          // return the original array
            if (arr == null || index < 0
                || index >= arr.Length)
            {

                return arr;
            }
            List<int> list = new List<int>();
            list.AddRange(arr);
            list.RemoveAt(index);// use remove at when delete by index number
            // return the resultant array
            return list.ToArray();
        }

    }
}
