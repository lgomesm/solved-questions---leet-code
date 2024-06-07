public class Solution {
    public int ReturnToBoundaryCount(int[] nums) {
        int position = 0;
        int boundary = 0;

        foreach (int i in nums) {
            position += i;
            if (position == 0) {
                boundary += 1;
            }
        }

        return boundary;
    }
}