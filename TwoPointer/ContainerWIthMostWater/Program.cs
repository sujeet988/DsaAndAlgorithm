namespace ContainerWIthMostWater
{
    internal class Program
    {
        /*
         * Area = Width * Height
        /*

        /*
         * https://leetcode.com/problems/container-with-most-water/description/
         */

        public static int MaxAreaBruteForce(int[] height)
        {
            int max = 0;
            int count = 0;

            for (int i = 0; i < height.Length; i++)
            {
         
                for (int j = i + 1; j < height.Length; j++)
                {
                   
                    int minheight = Math.Min(height[j], height[i]);
                    int width = j - i; // width is sum of 0 to n-1 
                    int area = minheight * width;

                    if (area > max)
                    {
                        max = area;
                    }

                }

            }
            return max;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("ContainerWIthMostWater");

            int[] height = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            var resultmaxarea = MaxAreaBruteForce(height);
            Console.WriteLine(resultmaxarea);

            Console.ReadLine();
        }
    }
}
