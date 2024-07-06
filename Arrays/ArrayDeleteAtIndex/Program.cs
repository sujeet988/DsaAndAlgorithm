using System;

namespace ArrayDeleteAtIndex
{
    /*
     * https://www.geeksforgeeks.org/remove-an-element-at-specific-index-from-an-array-in-java/
     */
    internal class Program
    {
        //Complete this function
        // O(n)
        public static int DeleteElement(int[] arr, int sizeOfArray,int element)
        {
            //Your code here
            // Shift All  Element to right for given index and the  after loop places element at index.
            int i;
            for(i=0; i < sizeOfArray; i++)
            {
                if (arr[i] == element)
                {
                    break;
                }
            }
            if (i == sizeOfArray) // this means element not found because i==size of the array
            {
                return sizeOfArray;
            }
            // Shifting elements

            for (int j = i + 1; j < sizeOfArray; j++)
            {
                arr[j - 1] = arr[j];
            }
            return sizeOfArray- 1;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Arrays Delete At Index");
            int[] arr = new int[5];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            arr[3] = 4;
            arr[4] = 5;
            //Before insert
            Console.WriteLine("Before Delete");
            foreach (int item in arr)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine("Array length before delete is : " + arr.Length);
            Console.WriteLine("after Delete");
            int sizeOfArray = arr.Length;
            int element = 3;
            var output= DeleteElement(arr, sizeOfArray, element); //output
            Console.WriteLine("Array length is  {0} after  deleting element :   {1} ", output,element );                                                   
             for(int i=0; i < output; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
