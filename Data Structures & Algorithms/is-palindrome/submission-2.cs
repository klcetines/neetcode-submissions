public class Solution {
    public bool IsPalindrome(string s) {
        string result = Regex.Replace(s, "[^a-zA-Z0-9]", "").ToLower();
        if(result.Length <= 0) return true;
        int l = 0;
        int r = result.Length-1;
        while((result[l] == result[r]) && (l < r)){
            l++;
            r--;
        }
        return l >= r;
    }
}
