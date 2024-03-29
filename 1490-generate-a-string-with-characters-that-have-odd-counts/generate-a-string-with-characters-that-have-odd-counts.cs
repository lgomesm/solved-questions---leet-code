public class Solution {
    public string GenerateTheString(int n) {
       string result;

       if (n % 2 != 0) {
           result = new string('a', n);
       } else {
           result = new string('a', n - 1) + 'b';
       }

       return result;
    }
}