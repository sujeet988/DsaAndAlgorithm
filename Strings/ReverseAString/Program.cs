using System;
using System.Text;

namespace DsaAndAlgorithm.Strings.ReverseAString
{
    internal class Program
    {
        public static string ReverseWordsInString(string str)
        {
            // Write your code here.
            string[] str1 = str.Split(" ");
            StringBuilder sb = new StringBuilder();
            for (int i = str1.Length - 1; i >= 0; i--)
            {
                sb.Append(str1[i]);
                if (i > 0) { sb.Append(' '); }
            }
            return sb.ToString();
        }

        // by two pointer
        public static string ReverseWordsInString2(string S)
        {
            string[] str = S.Split('.');

            int start = 0;
            int end = str.Length - 1;
            while (start <= end)
            {
                string temp = str[end];
                str[end] = str[start];
                str[start] = temp;
                start++;
                end--;

            }
            string stroutput = String.Join(".", str);
            return stroutput;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Reverse Words In String");
            string str = "My name is sujeet";
            var output = ReverseWordsInString(str);
            Console.WriteLine(output); //output : sujeet is name my
            Console.ReadLine();
        }
    }
}
