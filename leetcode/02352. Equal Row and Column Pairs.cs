public class Solution {
    public int EqualPairs(int[][] grid) {
        var rowBuilder = new StringBuilder();
        var columnBuilder = new StringBuilder();
        var occurrences = new Dictionary<string, int>();

        for (var i = 0; i < grid.Length; ++i)
        {
            for (var j = 0; j < grid.Length; ++j)
            {
                rowBuilder.Append(grid[i][j]);
                rowBuilder.Append('+');
            }

            var row = rowBuilder.ToString();
            if (occurrences.TryGetValue(row, out var count))
            {
                occurrences[row] = count + 1;
            }
            else
            {
                occurrences[row] = 1;
            }

            rowBuilder.Clear();
        }

        var result = 0;

        for (var i = 0; i < grid.Length; ++i)
        {
            for (var j = 0; j < grid.Length; ++j)
            {
                columnBuilder.Append(grid[j][i]);
                columnBuilder.Append('+');
            }

            var column = columnBuilder.ToString();

            if (occurrences.TryGetValue(column, out var count))
            {
                result += occurrences[column];
            }

            columnBuilder.Clear();
        }

        return result;
    }
}