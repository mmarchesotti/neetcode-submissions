public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var seen = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            var num = nums[i];
            if (seen.ContainsKey(target - num)) {
                return new int[] {seen[target-num], i};
            }
            seen[num] = i;
        }
        return null;
    }
}