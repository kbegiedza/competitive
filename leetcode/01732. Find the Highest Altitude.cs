public class Solution {
    public int LargestAltitude(int[] gain) {
        var maxAltitude = 0;
        var altitude = 0;

        for (var i = 0; i < gain.Length; ++i)
        {
            altitude += gain[i];

            if (maxAltitude < altitude)
            {
                maxAltitude = altitude;
            }
        }

        return maxAltitude;
    }
}