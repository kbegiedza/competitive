public class Solution
{
    public int[] SortArrayByParity(int[] nums)
    {
        var oddIterator = 0;

        for (var i =0; i < nums.Length; ++i)
        {
            if (IsOdd(nums[i]))
            {
                oddIterator = i;

                break;
            }
        }

        if(oddIterator == nums.Length)
        {
            return nums;
        }

        for (var i = nums.Length-1; i >= 0; --i)
        {
            if(IsEven(nums[i]))
            {

                var t = nums[i];
                nums[i] = nums[oddIterator];
                nums[oddIterator] = t;

                for (var j = oddIterator+1; j < i; ++j)
                {
                    if (IsOdd(nums[j]))
                    {
                        oddIterator = j;

                        break;
                    }
                }
            }

            if(oddIterator >= i)
            {
                break;
            }
        }

        return nums;
    }

    private bool IsEven(int value) => (value & 1) == 0;
    private bool IsOdd(int value) => (value & 1) == 1;
}