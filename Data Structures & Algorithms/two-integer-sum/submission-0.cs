public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> seen = new Dictionary<int,int>();
        int n = nums.Length;
        int num = 0;
        int numprev = 0;
        int[] result = [];
        for (int i = 0; i < n; i++) {
            num = nums[i];
            numprev = target-num;
            if (seen.ContainsKey(numprev)) {
                return [seen[numprev],i];
            }
            else {
                if (!seen.ContainsKey(num)) {
                    seen.Add(num,i);
                }
            }
        }
        return [];
    }
}
