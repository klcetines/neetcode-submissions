public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        List<List<string>> res = new List<List<string>>();
        Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();
        foreach(string s in strs){
            string aux = String.Concat(s.OrderBy(c => c));
            if(!words.ContainsKey(aux)) words.Add(aux, new List<string>());
            words[aux].Add(s);
        }
        foreach (var i in words){
            List<string> temp  = new List<string>();
            foreach (var word in i.Value){
                temp.Add(word);
            }
            res.Add(temp);
        }
        return res;
    }
}
