namespace FreqencyOfNumberInArray
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hashing Demo");

            int[] arr = new int[5] { 1, 3, 2, 1, 3 };

            // Using Hashing
            // In question must be given length of array
            // create hasing array with array length +1
            // take example maximum length given 12

            int[] hash = new int[13]; // taken 13 as array start from 0
            for (int i = 0; i < arr.Length; i++)
            {
                hash[arr[i]] += 1;
            }

            int[] arrinput = new int[5] { 1, 4, 2, 3, 12 }; //  count all these elements exists in arr
            for (int i = 0; i < arrinput.Length; i++)
            {
                Console.WriteLine(arrinput[i] + " Count is => " + hash[arrinput[i]]);
            }

            /*
                Input: 

                5
                1 3 2 1 3
                5
                1 4 2 3 12

                Output: 

                2
                0
                1
                2
                0
             */

            Console.ReadLine();

        }
    }
}