public class Solution {
    public bool CheckIfExist(int[] arr) {
        var outerLoops = arr.Length - 1;
        var innerLoops = arr.Length;

        for(var i = 0; i < outerLoops; ++i)
        {
            for(var j = i + 1; j < innerLoops; ++j)
            {
                if(arr[i] == 2 * arr[j] || 2 * arr[i] == arr[j])
                {
                    return true;
                }
            }
        }

        return false;
    }
}