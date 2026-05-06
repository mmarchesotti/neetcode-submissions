import re

class Solution:
    def isPalindrome(self, s: str) -> bool:
        formatted_s = "".join([char.lower() for char in s if char.isalnum()])
        return formatted_s == formatted_s[::-1]

        