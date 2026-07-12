public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> dict = new Dictionary<int,int>();
        int[] res = new int[k];
        foreach (var it in nums){
            if(!dict.ContainsKey(it)) dict.Add(it, 0);
            dict[it]++;
        }

        var pq = new PriorityQueue<int, int>(dict.Select(kvp => (kvp.Key, kvp.Value)), Comparer<int>.Create((a, b) => b.CompareTo(a)));
        for(int i = 0; i < k; i++) res[i] = pq.Dequeue();
        return res;
    }
}
