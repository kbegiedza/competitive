public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        var i = 0;
        var j = 0;

        while (j < nums.Length)
        {
            if(nums[i] == 0)
            {
                if(nums[j] != 0)
                {
                    nums[i] = nums[j];
                    nums[j] = 0;

                    ++i;
                }
            }
            else
            {
                ++i;
            }

            ++j;
        }
    }
}