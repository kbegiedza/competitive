public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        var result = new HashSet<int>();

        var n = nums.Length;

        for(var i = 1; i < n+1; ++i)
        {
            result.Add(i);
        }

        for(var i = 0; i < n; ++i)
        {
            result.Remove(nums[i]);
        }

        return result.ToList();
    }
}