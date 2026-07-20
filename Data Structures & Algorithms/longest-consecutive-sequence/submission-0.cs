public class Solution {
    public int LongestConsecutive(int[] nums) {
       HashSet<int> numSet = new HashSet<int>(nums);
        int res = 0;

        foreach (int num in numSet) {
            if (!numSet.Contains(num - 1)) {
                int length = 1;
                int current = num;

                while (numSet.Contains(current + 1)) {
                    current++;
                    length++;
                }

                res = Math.Max(res, length);
            }
        }
        return res;
    }
}
