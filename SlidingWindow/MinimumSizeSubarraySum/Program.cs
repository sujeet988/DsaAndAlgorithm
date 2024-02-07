namespace MinimumSizeSubarraySum
{
    /*
     
    Given an array of integers (A[])  and a number x, 
    find the smallest subarray with sum greater than the given value. 
    If such a subarray do not exist return 0 in that case.

    Example 1:
    Input:
    A[] = {1, 4, 45, 6, 0, 19}
    x  =  51
    Output: 3
    Explanation:
    Minimum length subarray is 
    {4, 45, 6}

    Example 2:
    Input:
    A[] = {1, 10, 5, 2, 7}
    x  = 9
    Output: 1
    Explanation:
    Minimum length subarray is {10}

     */

  


    internal class MinimumSizeSubarray
    {
        //O(n^2)
        public static int smallestSubWithSumBruteForce(int[] a, int n, int x)
        {
            // Your code goes here 

            //Declare a variable and assign integer max value
            int minLength = Int32.MaxValue;
            for (int i = 0; i < n; i++)

            {
                int sum = 0;
                //Inner starts from the value of i
                for (int j = i; j < n; j++)
                {
                    //Add the value in sum variable
                    sum += a[j];
                    /*
                 If the value of sum is greater than or equal to
                 the value of k.
                */
                 if (sum > x)
                   {
                        //Update the value of minlength, if it's applicable
                        minLength = Math.Min((j - i) + 1, minLength);
                        break;
                    }

                }

            }
            
            //Return minlength
            if (minLength == Int32.MaxValue)
            {
                return 0;
            }
            else
            {
                return minLength;
            }


        }

        // O(n)
        public static int smallestSubWithSumSlidingWindow(int[] a, int n, int x)
        {
            // Your code goes here 

            int minLength = Int32.MaxValue;
            int start = 0;
            int sum = 0;

            for(int end=0; end < n; end++)
            {
                sum += a[end];
                if(x> sum && start<=end)
                {
                    minLength = Math.Min((end - start) + 1, minLength);
                    sum = sum - a[start];
                    start++;
                }
            }

            return minLength == Int32.MaxValue?0: minLength;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Smallest subarray with sum greater than x\r\n");
            int[] arr = new int[6] { 1, 4, 45, 6, 0, 19 };
            int output=smallestSubWithSumSlidingWindow(arr, arr.Length, 51);
            Console.WriteLine(output); // 3 ans Minimum length subarray is { 4, 45, 6}
            Console.ReadLine();


        }
    }
}