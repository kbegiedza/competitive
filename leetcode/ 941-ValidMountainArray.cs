public class Solution {
    public bool ValidMountainArray(int[] arr) {

        if(arr.Length < 3)
        {
            return false;
        }

        var wasIncline = false;
        var wasDecline = false;

        for (int i = 0; i < arr.Length - 1; ++i)
        {
            if (arr[i] > arr[i+1] && wasIncline)
            {
                wasDecline = true;
            }
            else if(arr[i+1] > arr[i] && !wasDecline)
            {
                wasIncline = true;
            }
            else
            {
                return false;
            }
        }

        return wasIncline && wasDecline;
    }
}