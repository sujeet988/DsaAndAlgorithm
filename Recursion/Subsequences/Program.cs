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
            SubSeq(p + ch, up.Substring(1));  //take it
            SubSeq(p, up.Substring(1)); //ignore


        }
        static void Main(string[] args)
        {
            Console.WriteLine("Subsequences using recursion Demo");
            string input = "abc";
            string processed = "";
            Program.SubSeq(processed, input);
            Console.ReadLine();
        }
    }
}