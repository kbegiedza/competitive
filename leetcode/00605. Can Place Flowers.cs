public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        for (var i = 0; i < flowerbed.Length; ++i)
        {
            var left = i - 1;
            var right = i + 1;

            if (flowerbed[i] == 0)
            {
                // check left
                if (left >= 0
                    && flowerbed[left] == 1)
                {
                    continue;
                }

                // check right
                if (right < flowerbed.Length
                    && flowerbed[right] == 1)
                {
                    continue;
                }

                flowerbed[i] = 1;

                --n;
            }
        }

        return n <= 0;
    }
}