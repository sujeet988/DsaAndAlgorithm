using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionofTwoArrays
{
    public class UnionArrayDemo
    {

        //Brute force
        //Time Complexity: n + n * n = n + n2  = O (n2)
        // not a good approach
        public static List<int> findUnionByMergingint(int[] arr1, int[] arr2, int n, int m)
        {
            //Your code here
            //return array with correct order of elements
            int length = n + m;
            int[] arr3 = new int[length];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr3[i] = arr1[i];
            }

            for (int i = 0; i < m; i++)
            {
                bool isexists = false;
                for(int j=0; j < arr3.Length; j++)
                {
                    if (arr3[j] == arr2[i])
                    {
                        isexists = true;
                        break;
                    }
                }
                if (!isexists) //remove duplciate check
                {
                    arr3[n + i] = arr2[i];
                }
                

            }

            List<int> Union = new List<int>();
            Array.Sort(arr3);

            for (int i = 0; i < arr3.Length; i++)
            {
                Union.Add(arr3[i]);
            }
            return Union;

        }


        //arr1,arr2 : the arrays
        // n, m: size of arrays
        //Function to return a list containing the union of the two arrays.
        // using hash set
        public static List<int> findUnionBYHashSet(int[] arr1, int[] arr2, int n, int m)
        {
            //Your code here
            //return vector with correct order of elements

            HashSet<int> freq = new HashSet<int>();

            List<int> Union = new List<int>();

            for (int i = 0; i < n; i++)
            {
                freq.Add(arr1[i]);

            }

            for (int i = 0; i < m; i++)
            {
                freq.Add(arr2[i]);
            }

            foreach (var item in freq)
            {
                Union.Add(item);

            }
            Union.Sort();

            return Union;
        }

        //arr1,arr2 : the arrays
        // n, m: size of arrays
        //Function to return a list containing the union of the two arrays.
        // using  Dictionary/hashmap
        public static List<int> findUnionByDictionary(int[] arr1, int[] arr2, int n, int m)
        {
            //Your code here
            //return vector with correct order of elements

            Dictionary<int, int> freq = new Dictionary<int, int>();

            List<int> Union = new List<int>();

            for (int i = 0; i < n; i++)
            {
                if (freq.ContainsKey(arr1[i]))
                {
                    freq[arr1[i]]++;
                }
                else
                {
                    freq.Add(arr1[i], 1);

                }

            }

            for (int i = 0; i < m; i++)
            {
                if (freq.ContainsKey(arr2[i]))
                {
                    freq[arr2[i]]++;
                }
                else
                {
                    freq.Add(arr2[i], 1);

                }
            }

            foreach (var item in freq.Keys)
            {
                Union.Add(item);

            }
            Union.Sort();
            return Union;
        }

    }
}
