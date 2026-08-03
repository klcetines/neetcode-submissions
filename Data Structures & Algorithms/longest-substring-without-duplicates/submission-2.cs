public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> currStr = new HashSet<char>();
        int l = 0, maxSize = 0;

        for (int r = 0; r < s.Length; r++) {
            while (currStr.Contains(s[r])) {
                currStr.Remove(s[l]);
                l++;
            }
            currStr.Add(s[r]);
            maxSize = Math.Max(maxSize, r - l + 1);
        }

        return maxSize;
    }
}
