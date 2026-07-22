public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int r = numbers.Length-1;
        int l = 0;
        int sum = numbers[l] + numbers[r];
        while(r > l && sum != target){
            sum = numbers[l] + numbers[r];
            if(sum < target){
                l++;
            }
            else if (sum > target){
                r--;
            }
        }
        return [++l, ++r];
    }
}
