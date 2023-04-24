using System;
using System.Transactions;

namespace BestTimeToSellAndBuyStock
{
    /*
     * https://leetcode.com/problems/best-time-to-buy-and-sell-stock/description/
     * You are given an array of prices where prices[i] is the price of a given stock on an ith day.You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock. Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.
     */
    internal class Program
    {
        //Solution 1: Brute Force
        //Intuition: We can simply use 2 loops and track every transaction and maintain a variable maxPro to contain the max value among all transactions.


        public static int MaxProfitByTwoLoop(int[] prices)

        {
            int maxporfit = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                for (int j = i + 1; j < prices.Length; j++)
                {
                    int profit = prices[j] - prices[i];
                    if (profit > maxporfit)
                    {
                        maxporfit = profit;
                    }

                }

            }
            return maxporfit;

        }
        //Time complexity: O(n^2)
        //Space Complexity: O(1)

        //optimized
        //single loop
        public static int MaxProfit(int[] prices)

        {
            int leastSoFar = Int32.MaxValue; //for maintain previos least value take max valuiue of int
            int overallprofit = 0;
            int profitifsoldtoday = 0;

            for (int i = 0; i < prices.Length; i++)
            {

                if (prices[i] < leastSoFar)
                {
                    leastSoFar = prices[i];
                }
                profitifsoldtoday = prices[i] - leastSoFar;
                if (profitifsoldtoday > overallprofit)
                {
                    overallprofit = profitifsoldtoday;
                }
            }
            return overallprofit;

        }
        //Time complexity: O(n)
        //Space Complexity: O(1)

        static void Main(string[] args)
        {
            Console.WriteLine("Stock Buy And Sell");
            int[] arr = { 7, 1, 5, 3, 6, 4 };

            //Brute Force
            int maxPro = 0;
            maxPro = MaxProfit(arr);
            Console.WriteLine("Max profit by brute force approach is is: " + maxPro); //output 5

            //Optmized
            maxPro = MaxProfit(arr);
            Console.WriteLine("Max profit is: " + maxPro); //output 5

            Console.ReadLine();

        }
    }
}
