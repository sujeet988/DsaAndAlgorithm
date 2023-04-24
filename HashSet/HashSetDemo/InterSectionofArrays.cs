using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSetDemo
{
    internal class InterSectionofArrays
    {

        public static int GetCountofIntersecvtion(int[] arr1, int[] arr2)
        {
            int n =arr1.Length;
            int m = arr2.Length;
            HashSet<int> obj = new HashSet<int>();
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                obj.Add(arr1[i]);
            }

            for (int i = 0; i < m; i++)
            {
                if (obj.Contains(arr2[i]))
                {
                    count++;
                    obj.Remove(arr2[i]);
                }

            }
            return count;
        }
    }
}
