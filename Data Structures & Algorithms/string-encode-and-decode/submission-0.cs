public class Solution {

    public string Encode(IList<string> strs) {
        string s = "";
        foreach(var c in strs){
            s += c.Length + "#" + c;
        }
        return s;
    }

    public List<string> Decode(string s) {
        string str = "";
        List<string> strs = new List<string>();
        int i = 0;
        while(i < s.Length){
            int j = i;
            while(s[j] != '#'){
                j++;
            }
            
            int length = int.Parse(s.Substring(i, j - i));
            
            string word = s.Substring(j + 1, length);
            strs.Add(word);
            
            i = j + 1 + length;
        }        
        
        return strs;
   }
}
