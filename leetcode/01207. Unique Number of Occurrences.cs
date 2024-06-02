public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        var store = new Dictionary<int, int>();

        for (var i = 0; i < arr.Length; ++i)
        {
            var item = arr[i];

            if(store.TryGetValue(item, out var count))
            {
                store[item] = count + 1;
            }
            else
            {
                store[item] = 1;
            }
        }

        foreach(var kvp in store)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }

        var existingCounts = new HashSet<int>();

        foreach (var value in store.Values)
        {
            if (existingCounts.Contains(value))
            {
                return false;
            }

            existingCounts.Add(value);
        }

        return true;
    }
}