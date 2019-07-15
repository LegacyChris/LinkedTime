using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GetMaxProft
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solution solution = new Solution();
            int[] newStockPrices = new int[] { 20, 30, 40, 40, 15, 60 };
            Console.Write(GetMaxProfit(newStockPrices));
            Console.ReadLine();

        }
        public static int GetMaxProfit(int[] stockPrices)
        {
            // Calculate the max profit
            if (stockPrices.Length < 2)
            {
                throw new Exception("profit cannot be determined in this kind of scenario");
            }

            int minPrice = stockPrices[0];
            int maxProfit = stockPrices[1] - stockPrices[0];

            // Ensure minPrice is the lowest price we've seen so far
            for (int i = 1; i < stockPrices.Length; i++)
            {
                // See what our profit would be if we bought at the
                // min price and sold at the current price
                int currentPrice = stockPrices[i];
                int potentialProfit = currentPrice - minPrice;

                //Update the maxProfit
                maxProfit = Math.Max(maxProfit, potentialProfit);

                minPrice = Math.Min(minPrice, currentPrice);
            }


            return maxProfit;
        }
    }
    
}

