public class Solution {
    public int MajorityElement(int[] nums) {
        var counter = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; ++i)
        {
            var numVal = nums[i];
            if(counter.TryGetValue(numVal, out var value))
            {
                counter[numVal] = value + 1;
            }
            else
            {
                counter[numVal] = 1;
            }
        }

        var maxValue = int.MinValue;
        var maxItem = 0;

        foreach (var item in counter)
        {
            if (item.Value > maxValue)
            {
                maxItem = item.Key;
                maxValue = item.Value;
            }
        }

        return maxItem;
    }
}