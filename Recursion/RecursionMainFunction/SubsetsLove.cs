using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RecursionMainFunction
{
    /// <summary>
    /// https://leetcode.com/problems/subsets/
    /// </summary>
    internal class SubsetsLove
    {
        public static IList<IList<int>> Subsets(int[] nums)
        {
           List<List<int>> ans = new List<List<int>>();

           List<int> output = new List<int>();
            int index = 0;

            solve(nums, output, index,ans);

            return (IList<IList<int>>)ans;

        }

        public static void solve(int[] nums, List<int> output, int index, List<List<int>> ans)
        {
            if (index >= nums.Length)
            {
                ans.Add(output);
                return;
            }
            //ecluse
            solve(nums, output, index+1, ans);
            //include
            int element = nums[index];
            output.Add(element);
            solve(nums, output, index + 1, ans);
        }
        //include
      

    }
}
