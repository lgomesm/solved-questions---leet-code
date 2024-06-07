public class Solution {
    public bool IsPrefixString(string s, string[] words) {
        string concatenated = string.Empty;

        for (int i = 0; i < words.Length; i++) {
            concatenated += words[i];

            if (concatenated == s) {
                return true;
            }

            if (concatenated.Length > s.Length) {
                return false;
            }
        }

        return false; 
    }
}