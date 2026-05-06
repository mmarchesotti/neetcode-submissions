public class Solution {
    public bool IsPalindrome(string s) {
        int left_pointer = 0;
        int right_pointer = s.Length - 1;

        while (left_pointer < right_pointer) {
            if (!char.IsLetterOrDigit(s[left_pointer])) {
                left_pointer += 1;
                continue;
            }
            if (!char.IsLetterOrDigit(s[right_pointer])) {
                right_pointer -= 1;
                continue;
            }
            if (char.ToLower(s[left_pointer]) != char.ToLower(s[right_pointer])) {
                return false;
            }

            left_pointer += 1;
            right_pointer -= 1;
        }
        
        return true;
    }
}
