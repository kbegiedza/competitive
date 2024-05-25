public class Solution {
    public int MaxArea(int[] height) {
        var maxVolume = -1;

        var left = 0;
        var right = height.Length - 1;

        while(left < right)
        {
            var min = Math.Min(height[left], height[right]);
            var distance = right - left;
            var volume = min * distance;

            if (volume > maxVolume)
            {
                maxVolume = volume;
            }

            if (height[left] <= height[right])
            {
                ++left;
            }
            else
            {
                --right;
            }
        }

        return maxVolume;
    }
}