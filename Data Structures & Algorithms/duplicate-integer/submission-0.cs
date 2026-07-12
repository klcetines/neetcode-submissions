public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> exists = new HashSet<int>();
        foreach(var i in nums){
            if(exists.Contains(i)) return true;
            else exists.Add(i);
        }
        return false;
    }
}