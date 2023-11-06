public class Solution {
    public int MaximumCount(int[] nums) {
        int p=0;
        int n=0;
        foreach(int num in nums)
        {
            if(num < 0){
                ++n;
            }
            if(num > 0){
                p++;
            }
        }

        return Math.Max(p,n);
    }
}