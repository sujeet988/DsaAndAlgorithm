namespace DsaAndAlgorithm.Recursion.Subsequences
{
    internal class Program
    {

        static void SubSeq(string p, string up)
        {
            if (string.IsNullOrEmpty(up))
            {
                Console.WriteLine(p);
                return;
            }

            char ch = up[0];
            SubSeq(p + ch, up.Substring(1));  //// Include the current character
            SubSeq(p, up.Substring(1)); // Exclude the current character
        }

        static void SubSeq(string p, string up, List<string> subsequences)
        {
            if (string.IsNullOrEmpty(up))
            {
                subsequences.Add(p);
                return;
            }

            char ch = up[0];
            SubSeq(p + ch, up.Substring(1), subsequences);  //// Include the current character
            SubSeq(p, up.Substring(1), subsequences); // Exclude the current character
        }

        static List<string> SubSeqListReturn(string p, string up)
        {
            if (string.IsNullOrEmpty(up))
            {
                List<string> ret = new List<string>();
                ret.Add(p);
                return ret;
            }

            char ch = up[0];
          List<string> left= SubSeqListReturn(p + ch, up.Substring(1));  //// Include the current character
          List<string> right= SubSeqListReturn(p, up.Substring(1)); // Exclude the current character
          
          left.AddRange(right);
          return left;
        }

        public static List<string> SubSeqListusingLoop(string str)
        {
            List<string> Subsequences = new List<string>();
            Subsequences.Add(""); // Add an empty string as the initial subsequence
            foreach (char ch in str)
            {
                int count = Subsequences.Count;
                for (int i = 0; i < count; i++)
                {
                    Subsequences.Add(Subsequences[i] + ch); // Include the current character
                }
            }
            return Subsequences;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Subsequences using recursion Demo");
            string input = "abc";
            string processed = "";
            Program.SubSeq(processed, input); //using void
            //Output
            //abc
            //ab
            //ac
            //a
            //bc
            //b
            //c

            //using list store
            Console.WriteLine("Subsequences using  List ");
            List<string> subsequences = new List<string>();
            subsequences.Add("");
            Program.SubSeq(processed, input, subsequences);
            foreach(var item in subsequences)
            {
                Console.WriteLine(item);
            }
            // output :
            // abc
            //ab
            //ac
            //a
            //bc
            //b
            //c

            //using List Return type
            Console.WriteLine("Subsequences using  List return type ");
            var ouput = Program.SubSeqListReturn(processed, input);
            foreach (var item in ouput)
            {
                Console.WriteLine(item);
            }
            // Ouput 
            //abc
            //ab
            //ac
            //a
            //bc
            //b
            //c

            //using Loop
            Console.WriteLine("Subsequences using  Loop ");
            var outputloop = Program.SubSeqListusingLoop(input);
            foreach (var item in outputloop)
            {
                Console.WriteLine(item);
            }

            //Output 
            ////a
            ////b
            ////ab
            ////c
            ////ac
            ////bc
            ////abc


            Console.ReadLine();
        }
    }
}