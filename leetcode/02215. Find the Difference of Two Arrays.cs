public class Solution {
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {
        var h1 = nums1.ToHashSet();
        var h2 = nums2.ToHashSet();

        var result = new IList<int>[]
        {
            new List<int>(),
            new List<int>()
        };

        foreach(var item in h1)
        {
            if (!h2.Contains(item))
            {
                result[0].Add(item);
            }
        }

        foreach(var item in h2)
        {
            if (!h1.Contains(item))
            {
                result[1].Add(item);
            }
        }

        return result;
    }
}