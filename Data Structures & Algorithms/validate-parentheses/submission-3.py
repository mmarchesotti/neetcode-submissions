class Solution:
    def isValid(self, s: str) -> bool:
        openToClose = {"}":"{","]":"[",")":"("}
        stack = []
        for bracket in s:
            if bracket in openToClose:
                if not stack or stack.pop() != openToClose[bracket]:
                    return False
            else:
                stack.append(bracket)

        return len(stack) == 0
