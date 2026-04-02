namespace EnCodeDecodeString
{
    internal class Program
    {
        /*
         * https://neetcode.io/problems/string-encode-and-decode/question
        */
        public static string Encode(IList<string> str)
        {
            if (str.Count == 0)
            {
                return "";
            }

           
            string res = "";
           
            foreach (string s in str)
            {
                res += s.Length.ToString() + "#" + s;

            }
            Console.WriteLine(res);
            return res;
        }

        public static List<string> Decode(string str)
        {
            if (str.Length ==0)
            {
                return new List<string>();
            }
          
            List<string> result = new List<string>();
            int i = 0;  // Pointer to track current position in encoded string

            while (i < str.Length)
            {
                int j = i;  // j will move to find the '#' separator

                // 🔍 Step 1: Find the position of '#'
                // This separates length and actual string
                while (str[j] != '#')
                {
                    j += 1;
                }

                // 📏 Step 2: Extract length of the word
                // substring from i to j (excluding '#')
                // Example: "5#Hello" → "5"
                int length = Convert.ToInt32(str.Substring(i, j - i));

                // 🧾 Step 3: Extract the actual word
                // Starts right after '#' → (j + 1)
                // Take 'length' number of characters
                // Example: "Hello"
                result.Add(str.Substring(j + 1, length));

                // ➡️ Step 4: Move pointer to next encoded word
                // New position = after current word
                // j + 1 → start of word
                // + length → end of word
                i = j + 1 + length;
            }

            // ✅ Final decoded list
            return result;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Encode and Decode Demo");

            List<string> inputs = new List<string>();
            inputs.Add("Hello");
            inputs.Add("world");
            var endcoderesult = Program.Encode(inputs);

            var decodederesult = Program.Decode(endcoderesult);
            foreach (var input in decodederesult)
            {
                Console.WriteLine(input);
            }

            Console.ReadLine();


        }
    }
}
