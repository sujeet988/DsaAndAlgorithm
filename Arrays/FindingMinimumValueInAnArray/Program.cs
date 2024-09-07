namespace FindingMinimumValueInAnArray
{
    /*
     * https://www.geeksforgeeks.org/problems/find-minimum-and-maximum-element-in-an-array4428/1?itm_source=geeksforgeeks&itm_medium=article&itm_campaign=bottom_sticky_on_article
     * Given an array arr. Your task is to find the minimum and maximum elements in the array.
       Note: Return an array that contains two elements the first one will be a minimum element and the second will be a maximum of an array.
    Example:
    Input: arr = [3, 2, 1, 56, 10000, 167]
    Output: 1 10000
    Explanation: minimum and maximum elements of array are 1 and 10000.
     */

    public class Program
    {

        public static KeyValuePair<int,int> MinMax(int[] arr)
        {
            int min = Int32.MaxValue;
            int max = Int32.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return new KeyValuePair<int, int>(min, max);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Min and Max in Array Demo");
            int[] arr = new int[] { 3, 2, 1, 56, 10000, 167 };
            var output = MinMax(arr);
            Console.WriteLine("Min and Max in Array are " + output.Key + " " + output.Value); //output 1 10000
            Console.ReadLine();
        }
    }
}