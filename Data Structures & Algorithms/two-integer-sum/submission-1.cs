public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,List<int>> n = new Dictionary<int,List<int>>();
        for(int i=0; i<nums.Length; i++){
            int need = target-nums[i];
            if(n.ContainsKey(need)) return [n[need][0], i];
            if(!n.ContainsKey(nums[i])){
                n.Add(nums[i], new List<int>{i});
            }
            else n[nums[i]].Add(i);
        }
        return [-1,-1];
    }
}
