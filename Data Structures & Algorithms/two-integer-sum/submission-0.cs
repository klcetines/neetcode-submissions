public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,List<int>> n = new Dictionary<int,List<int>>();
        for(int i=0; i<nums.Length; i++){
            if(!n.ContainsKey(nums[i]))n.Add(nums[i], new List<int>{i});
            else n[nums[i]].Add(i);
        }
        foreach(var i in n){
            if(target-i.Key != i.Key){
                if(n.ContainsKey(target-i.Key))return [i.Value[0], n[target-i.Key][0]];
            }
            else{
                if(i.Value.Count >= 2) return [i.Value[0], i.Value[1]];
            }
        }
        return [-1,-1];
    }
}
