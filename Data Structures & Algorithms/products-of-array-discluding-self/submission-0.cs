public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
    int[] prefix = new int[n];
    int[] suffix = new int[n];
    int[] output = new int[n];

    // Pass 1: prefix products
    prefix[0] = 1;
    for (int i = 1; i < n; i++) {
        prefix[i] = prefix[i - 1] * nums[i - 1];
    }

    // Pass 2: suffix products
    suffix[n - 1] = 1;
    for (int i = n - 2; i >= 0; i--) {
        suffix[i] = suffix[i + 1] * nums[i + 1];
    }

    // Pass 3: multiply
    for (int i = 0; i < n; i++) {
        output[i] = prefix[i] * suffix[i];
    }

    return output;
    }
}
