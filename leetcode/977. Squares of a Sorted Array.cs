public class Solution {
    public int[] SortedSquares(int[] nums) {
        // find 'center value' -> zero or switch from negatives to positives
        // square smallest value from this point -> to left and right
        var startIndex = 0;
        var result = new int[nums.Length];

        for (var i = 0; i < nums.Length; ++i)
        {
            if (nums[i] < 0)
            {
                startIndex++;
            }
        }

        var pointerR = startIndex;
        var pointerL = startIndex - 1;

        for (var i = 0; i < result.Length; ++i)
        {
            if (pointerL >= 0)
            {
                var squareL = nums[pointerL]*nums[pointerL];

                if(pointerR < nums.Length)
                {
                    var squareR = nums[pointerR]*nums[pointerR];

                    if(squareL < squareR)
                    {
                        result[i] = squareL;
                        --pointerL;
                    }
                    else
                    {
                        result[i] = squareR;
                        ++pointerR;
                    }
                }
                else
                {
                    result[i] = squareL;
                    --pointerL;
                }
            }
            else if(pointerR < nums.Length)
            {
                var squareR = nums[pointerR]*nums[pointerR];

                if(pointerL >= 0)
                {
                    var squareL = nums[pointerL]*nums[pointerL];

                    if(squareL < squareR)
                    {
                        result[i] = squareL;
                        --pointerL;
                    }
                    else
                    {
                        result[i] = squareR;
                        ++pointerR;
                    }
                }
                else
                {
                    result[i] = squareR;
                    ++pointerR;
                }
            }
        }

        return result;
    }
}