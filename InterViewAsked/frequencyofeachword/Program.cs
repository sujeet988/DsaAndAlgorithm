namespace frequencyofeachword
{
    internal class Program
    {
        /*
         * frequecy of words in a list and output them in a sorted order
         * https://www.geeksforgeeks.org/calculate-the-frequency-of-each-word-in-the-given-string/
         */

        public static void CountFrequencyOfEachWord(string str)
        {
            SortedDictionary<string,int> dict=new SortedDictionary<string, int>();
            string[] strnew = str.Split(" ");
            foreach(string s in strnew)
            {
               if( dict.ContainsKey(s))
                {
                    dict[s]++;
                }
                else
                {
                    dict.TryAdd(s, 1);
                }
            }
            // way to  print 1
            foreach(var item in dict.Keys)
            {
                Console.WriteLine(item +" "+ dict[item]);
            }

            // way to ;rint2 
            foreach (KeyValuePair<string,int> item in dict)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

        }


        static void Main(string[] args)
        {
            string str = "geek for geek";
            CountFrequencyOfEachWord(str);
            Console.ReadLine();
        }
    }
}