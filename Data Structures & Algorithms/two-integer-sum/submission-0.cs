public class Solution {
    public int[] TwoSum(int[] nums, int target) {
Dictionary<int,int> sum = new Dictionary<int,int>();
for (int i = 0; i< nums.Length; i++ ){
     sum[nums[i]] = i;
}
for (int i = 0; i< nums.Length; i++ ){
 int diff = target - nums[i];
 if (sum.ContainsKey(diff) && sum[diff] != i ){
     return new int[]{i, sum[diff]};
 }                          
}

        return new int[0];

    }
}

