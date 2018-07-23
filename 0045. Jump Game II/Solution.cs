public class Solution {
    public int Jump (int[] nums) {
        if (nums.Length < 2) {
            return 0;
        }
        var level = 0;
        var currentLevelMax = 0;
        var nextLevelMax = 0;
        var i = 0;
        //nodes count of current level>0
        while (currentLevelMax - i + 1 > 0) {
            level++;
            //traverse current level , and update the max reach of next level
            for (; i <= currentLevelMax; i++) {
                nextLevelMax = Math.Max (nextLevelMax, nums[i] + i);
                // if last element is in level+1,  then the min jump=level 
                if (nextLevelMax >= nums.Length - 1) {
                    return level;
                }
            }
            currentLevelMax = nextLevelMax;
        }
        return 0;
    }
}