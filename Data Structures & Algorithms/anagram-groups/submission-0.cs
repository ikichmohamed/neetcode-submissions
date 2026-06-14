public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> groups = new();

        foreach (string word in strs)
        {
            int[] count = new int[26];

            foreach (char c in word)
            {
                count[c - 'a']++;
            }

            string key = string.Join(",", count);

            if (!groups.ContainsKey(key))
            {
                groups[key] = new List<string>();
            }

            groups[key].Add(word);
        }

        return groups.Values.Cast<List<string>>().ToList();
    }
}
