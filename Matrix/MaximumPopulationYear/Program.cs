namespace MaximumPopulationYear
{
    internal class Program
    {
        /*
            * You are given a 2D integer array logs where each logs[i] = [birthi, deathi] indicates the birth and death years of the ith person.

            The population of some year x is the number of people alive during that year. The ith person is counted in year x's population if x is in the inclusive range [birthi, deathi - 1]. Note that the person is not counted in the year that they die.

            Return the earliest year with the maximum population.
            Example 1:

            Input: logs = [[1993,1999],[2000,2010]]
            Output: 1993
            Explanation: The maximum population is 1, and 1993 is the earliest year with this population.
            Example 2:

            Input: logs = [[1950,1961],[1960,1971],[1970,1981]]
            Output: 1960
            Explanation: 
            The maximum population is 2, and it had happened in years 1960 and 1970.
            The earlier year between them is 1960.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Maximum Population Year Demo");

            int[,] logs = new int[3, 2] { { 1950, 1961 }, { 1960, 1971 }, { 1970, 1981 } };

            int[] years = new int[101];

            for (int i = 0; i < logs.GetLength(0); i++)
            {
                for (int j = logs[i,0]; j < logs[i,1] ; j++)
                {
                   
                    years[j - 1950]++;
                }
            }

            int max = 0;
            int maxyear = 1950;

            for(int i = 0; i < years.Length; i++) 
            {
                if (years[i] > max) 
                {
                    max = years[i];
                    maxyear = i + 1950;
                }
            }

            Console.WriteLine(maxyear); // 1960
            Console.ReadLine();

        }
    }
}