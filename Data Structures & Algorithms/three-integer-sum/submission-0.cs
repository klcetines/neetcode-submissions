public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
       List<List<int>> res = new List<List<int>>();
       int l, r;
       Array.Sort(nums);
       for(int i = 0; i<nums.Length-2;i++){
        if(i == 0 || nums[i] != nums[i-1]){
            l = i+1;
            r = nums.Length-1;
            while(l<r){
                if(nums[i] + nums[l] + nums[r] == 0){
                    res.Add([nums[i],nums[l],nums[r]]);
                    l++;
                    r--;
                    while(l < r && nums[l] == nums[l-1]) l++;
                    while(l < r && nums[r] == nums[r+1]) r--;
                }
                else if(nums[l] + nums[r] < -nums[i]) l++;
                else r--;
            }
        }
       }
       return res;
    }
}