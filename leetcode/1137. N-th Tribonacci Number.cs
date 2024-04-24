public class Solution {
    public int Tribonacci(int n)
    {
        if (n == 0)
        {
            return 0;
        }
        else if(n <= 2)
        {
            return 1;
        }

        var sum0 = 0;
        var sum1 = 1;
        var sum2 = 1;

        for (var i = 3; i <= n; ++i)
        {
            var tmpSum2 = sum2;
            sum2 = sum2 + sum1 + sum0;

            sum0 = sum1;
            sum1 = tmpSum2;
        }

        return sum2;
    }
}