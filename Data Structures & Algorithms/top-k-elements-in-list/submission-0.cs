public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
    int n = nums.Length;
    List<int>[] buckets = new List<int>[n + 1];
    Dictionary<int, int> count = new Dictionary<int, int>();

    foreach (int num in nums) {
        if (count.ContainsKey(num))
            count[num]++;
        else
            count.Add(num, 1);
    }

    foreach (KeyValuePair<int, int> entry in count) {
        if (buckets[entry.Value] == null)
            buckets[entry.Value] = new List<int>();
        buckets[entry.Value].Add(entry.Key);
    }

    List<int> result = new List<int>();
    int number_add = 0;

    for (int counter = n; counter > 0 && number_add < k; counter--) {
        if (buckets[counter] == null) continue;  // Bug 1 fix
        foreach (int num in buckets[counter]) {
            result.Add(num);                      // Bug 2 fix
            number_add++;
            if (number_add == k) break;
        }
    }

    return result.ToArray();                      // Bug 3 fix
}
}
