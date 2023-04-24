using System;
using System.Text;

namespace ReverseAString
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
