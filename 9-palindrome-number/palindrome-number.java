class Solution {
    public boolean isPalindrome(int x) {
        if (x < 0) {
            return false;
        }
        int y = x, w = 0, z;
        while (x > 0) {
            z = x%10;
            w = (w*10)+z;
            x = x / 10;
        }
        return y == w;
    }
}