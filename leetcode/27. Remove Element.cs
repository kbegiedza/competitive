public class Solution {
    public int RemoveElement(int[] nums, int val) {
        var leftItems = nums.Length;
        var right = nums.Length - 1;

        for (var left = 0; left <= right && left < nums.Length; ++left)
        {
            while (nums[left] == val)
            {
                leftItems--;

                if (left >= right)
                {
                    break;
                }

                nums[left] = nums[right];
                right--;
            }
        }

        return leftItems;
    }
}

/*
public class Solution {
    public int RemoveElement(int[] nums, int val)
    {
        var swapsCounter = 0;

        var rightIter = nums.Length - 1;

        // find first occurrence from end
        while(rightIter >= 0 && nums[rightIter] == val)
        {
            --rightIter;
            ++swapsCounter;
        }

        for (var leftIter = 0; leftIter <= rightIter; ++leftIter)
        {
            if(nums[leftIter] == val)
            {
                // swap
                nums[leftIter] = nums[rightIter];
                nums[rightIter] = val;

                // find next from end
                while(rightIter >= 0 && nums[rightIter] == val)
                {
                    --rightIter;
                    ++swapsCounter;
                }
            }
        }

        return nums.Length - swapsCounter;
    }
}
*/