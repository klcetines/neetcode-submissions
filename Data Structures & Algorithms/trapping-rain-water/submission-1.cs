public class Solution {
    public int Trap(int[] height) {
        if (height.Length <= 2) return 0;
        int res = 0;
        int[] pre = new int[height.Length];
        int[] suf = new int[height.Length];
        int currMax = -1;
        for(int i = 0; i< height.Length; i++){
            if (height[i] > currMax) currMax = height[i];
            pre[i] = currMax;
        }
        currMax = -1;
        for(int i = height.Length-1; i >= 0; i--){
            if (height[i] > currMax) currMax = height[i];
            suf[i] = currMax;
        }
        for(int i = 0; i < height.Length; i++){
            res += Math.Min(pre[i],suf[i]) - height[i];
        }

        return res;
    }
}
