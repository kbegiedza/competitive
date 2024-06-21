public class Solution {
    public bool IncreasingTriplet(int[] nums) {
        var min = int.MaxValue;
        var secMin = int.MaxValue;

        for (var i = 0; i < nums.Length; ++i) {
            if(nums[i] > min && nums[i] > secMin)
            {
                return true;
            }

            if (nums[i] > min && nums[i] < secMin)
            {
                secMin = nums[i];
            }
            else if (nums[i] < min)
            {
                min = nums[i];
            }
        }

        return false;
    }
}