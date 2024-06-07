public class Solution {
    public int MaxLengthBetweenEqualCharacters(string s) {
        int[] firstPosition = new int[26];
        int[] lastPosition = new int[26];

        for (int i = 0; i < 26; i++) {
            firstPosition[i] = -1;
            lastPosition[i] = -1;
        }

        for (int i = 0; i < s.Length; i++) {
            int index = s[i] - 'a';
            if (firstPosition[index] == -1) {
                firstPosition[index] = i;
            }
            lastPosition[index] = i;
        }

        int maxLength = -1;

        for (int i = 0; i < 26; i++) {
            if (firstPosition[i] != -1 && lastPosition[i] != firstPosition[i]) {
                int length = lastPosition[i] - firstPosition[i] - 1;
                if (length > maxLength) {
                    maxLength = length;
                }
            }
        }

        return maxLength;
    }
}