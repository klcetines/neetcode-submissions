public class Solution {
    public int Trap(int[] height) {
        if (height.Length <= 2) return 0;
        
        int l = 0, r = height.Length - 1;
        int maxIzq = 0, maxDer = 0;
        int res = 0;

        while (l < r) {
            if (height[l] < height[r]) {
                if (height[l] >= maxIzq) {
                    maxIzq = height[l];
                } 
                else {
                    res += maxIzq - height[l];
                }
                l++;
            } 
            else {
                if (height[r] >= maxDer) {
                    maxDer = height[r];
                } 
                else {
                    res += maxDer - height[r];
                }
                r--;
            }
        }

        return res;
    }
}
