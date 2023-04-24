using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSetDemo
{
    internal class UnionOFTwoArrays
    {
        public static int GetUnionOFtwoarrays(int[] arr1,int[] arr2)
        {
            HashSet<int> union = new HashSet<int>();
            for(int i=0; i < arr1.Length; i++)
            {
                union.Add(arr1[i]);
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                union.Add(arr2[i]);
            }
            return union.Count;
        }
      
    }
}
