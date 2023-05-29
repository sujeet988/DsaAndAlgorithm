using System;

namespace SkipChracter
{
    internal class Program
    {
        public static void Skip(string processed, string unprocessed)
        {
            if (string.IsNullOrEmpty(unprocessed))
             {
                Console.WriteLine(processed);

                return;
            }
            char ch = unprocessed[0];
            if (ch == 'e')
            {
                Skip(processed, unprocessed.Substring(1));
            }
            else
            {
                Skip(processed+ch, unprocessed.Substring(1));
            }

        }

        public static string SkipWithReturnsType(string processed, string unprocessed)
        {
            if (string.IsNullOrEmpty(unprocessed))
            {
             
                return processed;
            }

            char ch = unprocessed[0];
            if (ch == 'e')
            {
               return SkipWithReturnsType(processed, unprocessed.Substring(1));
            }
            else
            {
                return SkipWithReturnsType(processed+ch,unprocessed.Substring(1));
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Skip a chracters in String");
            String str = "sujeet";
            Console.WriteLine(str);
            Console.WriteLine("After Skip e in string");
            Skip("", str);

            //With return types
             str = "deeemo";
            var ouput=SkipWithReturnsType("", str);
            Console.WriteLine(ouput);
            Console.ReadLine();
        }
    }
}
