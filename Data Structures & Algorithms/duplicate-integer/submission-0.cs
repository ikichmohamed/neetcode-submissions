public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int,int> elts = new Dictionary<int,int>();
        bool result = false;
        foreach (int num in nums){
            if (elts.ContainsKey(num)) {
                result = true;
                Console.WriteLine($"Result = {result}");
                break;
            }
            else {
                elts.Add(num,1);
            }
        }
        return result;
    }
}