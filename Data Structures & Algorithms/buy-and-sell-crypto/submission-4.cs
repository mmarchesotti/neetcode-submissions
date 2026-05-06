public class Solution {
    public int MaxProfit(int[] prices) {
        var minValue = prices[0];
        var maxProfit = 0;
        for (int i = 0; i < prices.Length; i++) {
            maxProfit = Math.Max(maxProfit, prices[i] - minValue);
            minValue = Math.Min(minValue, prices[i]);
        }
        return maxProfit;
    }
}
