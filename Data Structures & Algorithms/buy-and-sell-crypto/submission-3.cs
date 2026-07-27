public class Solution {
    public int MaxProfit(int[] prices) {
        if(prices.Length <= 1) return 0;
        int currBuy = 0; int minBuy = 0; 
        int maxSell = 1;

        for(int i = 1; i < prices.Length; i++){
            if(prices[i] < prices[currBuy])currBuy = i;
            if ((prices[i] - prices[currBuy]) > (prices[maxSell] - prices[minBuy])){
                minBuy = currBuy;
                maxSell = i;
            }
        }
        Console.WriteLine("Sell Price: " + prices[maxSell] + " Buy Price: " + prices[minBuy]);
        return Math.Max(prices[maxSell]-prices[minBuy], 0);
    }
}
