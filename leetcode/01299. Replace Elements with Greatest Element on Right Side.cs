public class Solution {
    public int[] ReplaceElements(int[] arr) {
        var max = -1;

        for(var i = arr.Length-1; i >= 0; --i)
        {
            var tmp = arr[i];

            arr[i] = max;

            if(tmp > max)
            {
                max = tmp;
            }
        }

        return arr;
    }
}