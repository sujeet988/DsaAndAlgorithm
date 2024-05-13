namespace MaximizeStockProfits
{
    /*
     https://stackoverflow.com/questions/65775864/interview-question-maximize-stock-profits
    0

So I came across this question during an interview and was unable to solve it. Hopefully, someone can advise. The problem is this.

Imagine you have S amounts of savings in integers. You are thinking of buying stocks. Someone has provided you with 2 N-sized arrays of stock purchase prices, and their sell prices the following day. Write an algorithm that is able to take in S and the 2 arrays, and return the maximum profits that you are able to achieve the following day. Note that the lengths of the 2 arrays are equal. The number at index i in the first array shows the purchase price of the ith stock and the number at index i in the second array shows the sell price of the ith stock.

eg. S = 10, buy_price = [4, 6, 5], sell_price = [6, 10, 7], your savings are 10, there are 3 stock options. The first option the purchasing price is 4, and the selling price is 6 the next day. The second option purchasing price is 6 and the selling price is 10 the next day. So on and so forth. The maximum profit here is 6 where you buy the stock options that cost 4 and 6. and sell them the next day. Your function should return 6 here.

My initial approach was finding the profits/cost ratio of each stock and sorting them. However, this may not lead to the most ideal stock purchases. For example, for this case S = 10, buy_price = [6, 5, 5], sell_price = [12, 9, 8], the best option is not to buy the stock that cost 6 even though it has the highest profits/cost ratio (you can't buy anything with your remaining 4 savings) but to buy the other 2 stock options for a maximum profit of 7.

Does anyone have any idea of how to tackle this problem? Thank you!
     */

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}