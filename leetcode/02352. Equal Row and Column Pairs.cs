public class Solution {
    public int EqualPairs(int[][] grid) {
        var result = 0;

        for (var i = 0; i < grid.Length; ++i)
        {
            for (var j = 0; j < grid.Length; ++j)
            {
                var isOk = true;

                for(var item = 0; item < grid.Length; ++item)
                {
                    if (grid[i][item] != grid [item][j])
                    {
                        isOk = false;
                        break;
                    }
                }

                if(isOk)
                {
                    result++;
                }
            }
        }

        return result;
    }
}