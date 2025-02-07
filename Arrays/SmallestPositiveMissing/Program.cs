namespace SmallestPositiveMissing
{
    internal class Program
    {
        /*
        * You are given an integer array arr[]. Your task is to find the smallest positive number missing from the array.

        Note: Positive number starts from 1. The array can have negative integers too.

        Examples:

        Input: arr[] = [2, -3, 4, 1, 1, 7]
        Output: 3
        Explanation: Smallest positive missing number is 3.
         */
        // brute force using sorting

        public static int missingNumberbruteforce(int[] arr)
        {
            // Your code here

            int len = arr.Length;
            Array.Sort(arr);

            int count = 1;

            for (int i = 0; i < len; i++)
            {
                if (arr[i] == count)
                {
                    count++;
                }

            }


            return count;
        }

        public static int missingNumberusingFlag(int[] arr)

        {
            // Your code here

            int len = arr.Length;

            bool[] flag = new bool[len + 2];
            // ans -> [1,size+1] , so I need 1 to size+1 indexes in the flag array 
            // flag array will be of length size+2, becuase we need indexes from [1..sizse+1]
            int newlen = flag.Length;

            for (int i = 0; i < len; i++)
            {

                if (arr[i] > 0 && arr[i] < flag.Length) // values is less then 0 and out of the  new array.length ignore this
                {
                    int temp = arr[i];
                    flag[temp] = true; // i// if valid element 

                }

            }



            int output = 0;

            for (int i = 1; i < flag.Length; i++)
            {
                if (flag[i] == false) // first value if value is false then it is missing number
                {
                    output = i;
                    break;
                }
            }


            if (output == 0)
            {
                return flag.Length;
            }

            return output;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Smallest Positive Missing");
            int[] arr = { 2, -3, 4, 1, 1, 7 };

            Console.WriteLine(missingNumberbruteforce(arr)); // ans is 3
            Console.WriteLine(missingNumberusingFlag(arr)); // ans is 3
            Console.ReadLine();
        }
    }
}
