class Solution {
    public int reverse(int x) {
        long reversedNumber = 0;
        boolean isNegative = x < 0;
        if (isNegative) {
            x *= -1;
        }
        String numberAsString = Integer.toString(x);
        char[] numberAsCharArray = numberAsString.toCharArray();
        for (int i = numberAsCharArray.length - 1; i >= 0; i--) {
            reversedNumber = reversedNumber * 10 + Character.getNumericValue(numberAsCharArray[i]);
            if (reversedNumber > Integer.MAX_VALUE || reversedNumber < Integer.MIN_VALUE) {
                return 0;
            }
        }
        return isNegative ? (int) reversedNumber * -1 : (int) reversedNumber;
    }
}