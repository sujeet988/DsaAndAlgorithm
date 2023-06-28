namespace DsaAndAlgorithm.Rercursion.SkipCharacters
{
    internal class Program
    {
        public static void SkipCharacters(string processed, string unprocessed)
        {
            if (unprocessed.Length == 0)
            {
                Console.WriteLine(processed);
                return;
            }
            char ch = unprocessed[0];
            if (ch == 'e')
            {
                SkipCharacters(processed, unprocessed.Substring(1));
            }
            else
            {
                SkipCharacters(processed+ ch, unprocessed.Substring(1));
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Skip a string using void retun and recursion");
            string name = "sujeet";
            Console.WriteLine("string after remove e from string ");
            SkipCharacters("", name); // output sujt

            Console.ReadLine();
        }
    }
}