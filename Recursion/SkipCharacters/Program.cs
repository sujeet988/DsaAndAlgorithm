namespace DsaAndAlgorithm.Rercursion.SkipCharacters
{
    internal class Program
    {
        /*
         * Unprocessed -> original string
         * processed -> output/modified string
         */


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
                SkipCharacters(processed + ch, unprocessed.Substring(1));
            }
        }

        public static string SkipCharactersWithReturnsType(string processed, string unprocessed)
        {
            if (string.IsNullOrEmpty(unprocessed))
            {
                return processed;

            }
            char ch = unprocessed[0];
            if (ch == 'e')
            {
                return SkipCharactersWithReturnsType(processed, unprocessed.Substring(1));
            }
            else
            {
                return SkipCharactersWithReturnsType(processed + ch, unprocessed.Substring(1));
            }
        }

        public static string SkipCharactersWithReturnsTypeWithoutParamters(string unprocessed)
        {
            if (string.IsNullOrEmpty(unprocessed))
            {
                return " ";
            }
            char ch = unprocessed[0];

            if (ch == 'e')
            {
                return SkipCharactersWithReturnsTypeWithoutParamters(unprocessed.Substring(1));
            }
            else
            {
              return  ch + SkipCharactersWithReturnsTypeWithoutParamters(unprocessed.Substring(1));
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Skip a string using void retun and recursion");
            string name = "sujeet";
            Console.WriteLine("string after remove e from string ");
            SkipCharacters("", name); // output sujt

            // skip characters using return type
            var output = SkipCharactersWithReturnsType("", name);
            Console.WriteLine(output); // output sujt

            //SkipCharactersWithReturnsTypeWithoutParamters
            var result = SkipCharactersWithReturnsTypeWithoutParamters(name);
            Console.WriteLine(result); // output sujt

            Console.ReadLine();
        }
    }
}