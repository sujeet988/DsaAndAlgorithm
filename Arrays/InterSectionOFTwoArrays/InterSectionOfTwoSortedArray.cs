using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace InterSectionOfTwoSortedArrays
{


    internal class InterSectionOfTwoSortedArray
    {
        //Brute Force Approach:

        public static List<int> intersectionOfArrays(int[] A, int[] B)
        {
            List<int> ans = new List<int>();

            // to maintain visited 
            int[] visited = new int[B.Length];

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < B.Length; j++)
                {

                    if (A[i] == B[j] && visited[j] == 0)
                    {

                        //if element matches and has not been matched with any other before
                        ans.Add(B[j]);
                        visited[j] = 1;

                        break;
                    }
                    else if (B[j] > A[i]) break;
                    //because array is sorted , element will not be beyond this
                }
            }
            return ans;
        }
        //// Time Complexity: O(n1 x n2) ~O(n^2) { There are nested loops where the outer one loops n1 times and the inner one loops n2 times, where n1 = A.size() and n2 = B.size()
        //// }.
        ////Space Complexity: O(n) { Extra Space used for the visited and ans arrays }.

        //Optimized approach:
        public static List<int> intersectionOfArraysByTwoPointer(int[] A, int[] B)
        {

            // Declare ans array.
            List<int> ans = new List<int>();

            int i = 0, j = 0;

            // to traverse the arrays
            while (i < A.Length && j < B.Length)
            {

                //if current element in i is smaller
                if (A[i] < B[j])
                {
                    i++;
                }
                else if (B[j] < A[i])   //if current element in i is higher
                {
                    j++;
                }
                else  //if A[i] == B[j]//equals
                {

                    //both elements are equal
                    ans.Add(A[i]);
                    i++;
                    j++;
                }
            }
            return ans;
        }
       // Time Complexity: O(n) { Since the elements are compared within the single pass for both the arrays this approach would take a linear time and in the worst case O(n1 + n2) where n1 = A.size() and n2 = B.size() }.
        //Space Complexity: O(1) { There is no extra space used in the two-pointers approach }.
    }
}

