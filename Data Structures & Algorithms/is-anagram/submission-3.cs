public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        Dictionary<char,int> letters = new Dictionary<char,int>();
        foreach(var l in s){
            if(!letters.ContainsKey(l))letters.Add(l, 1);
            else letters[l]++;
        }
        foreach(var l in t){
            if(letters.ContainsKey(l) && letters[l]>0)letters[l]--;
            else return false;
        }
        return true;
    }
}
