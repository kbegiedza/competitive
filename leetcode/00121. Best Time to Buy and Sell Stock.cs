public class Solution {
    public int MaxProfit(int[] prices)
    {
        var buy = prices[0];
        var maxProfit = 0;

        for (var i = 1; i < prices.Length; ++i)
        {
            if (prices[i] < buy)
            {
                buy = prices[i];
            }
            else if (prices[i] - buy > maxProfit)
            {
                maxProfit = prices[i] - buy;
            }
        }

        return maxProfit;
    }
}