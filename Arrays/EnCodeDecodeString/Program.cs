namespace EnCodeDecodeString
{
    internal class Program
    {
        /*
         * https://neetcode.io/problems/string-encode-and-decode/question
        */
        public static string Encode(IList<string> str) 
        {
            return "";
        }

        public static List<string> Decode(string str)
        {
            List<string> result = new List<string>();

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
