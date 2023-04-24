using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AnargramOfString
{
    internal class CheckStringISAnargram
    {

        public static bool isAnagram(string a, string b)
        {
            //Your code here
             int chardata= 256;
            if (a.Length != b.Length)
            {
                return false;
            }
            int[] count=new int[chardata];

            for(int i=0; i <a.Length; i++)
            {
                count[a[i]]++;
                count[b[i]]--;
            }

            for(int i=0; i < count.Length; i++)
            {
                if (count[i] != 0)
                {
                    return false;
                }

            }
            return true;

        }

        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
           if(strs.Length== 0)
            {
                return new List<IList<string>>();
            }

            Dictionary<string,IList<string>> dic= new Dictionary<string,IList<string>>();

            foreach (string str in strs)
            {
                char[] arr = str.ToCharArray();
                Array.Sort(arr);
                string sorted = new string(arr);
                if (dic.ContainsKey(sorted))
                {
                    dic[sorted].Add(str);
                }
                else
                {
                    dic.Add(sorted, new List<string>() { str });
                }

            }
            var result = dic.Values.ToList();
            return result;
        }
    }
}
