public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int[] left = new int[n];
        int[] right = new int[n];
        left[0] = nums[0];
        right[n-1] = nums[n-1];

        for(int i = 1; i < n; i++){
            int rIndex = n-i-1;
            left[i] = nums[i] * left[i-1];
            right[rIndex] = nums[rIndex] * right[rIndex+1];
        }

        int[] res = new int[n];
        res[0] = right[1];
        res[n-1] = left[n-2];
        for(int i = 1; i < n-1; i++){
            res[i] = left[i-1] * right[i+1];
        }
        return res;
    }
}
