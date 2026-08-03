public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(s.Length < 1) return 0; 
        int maxSize = -1; int currentSize = 0;
        int l = 0; int r = 1;
        HashSet<int> currStr = new HashSet<int>();
        currStr.Add(s[0]);
        currentSize++;
        while(r < s.Length && l < r){
            while(currStr.Contains(s[r]) && l < r){
                currStr.Remove(s[l]);
                l++;
                currentSize--;
            }
            currStr.Add(s[r]);
            r++;
            currentSize++;
            maxSize = Math.Max(currentSize, maxSize);
        }
        return Math.Max(currentSize, maxSize);
    }
}
