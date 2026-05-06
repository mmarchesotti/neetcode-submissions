class Solution:
    def isValid(self, s: str) -> bool:
        stack = []
        for bracket in s:
            if self.isOpenBracket(bracket):
                stack.append(bracket)
            else:
                if len(stack) == 0:
                    return False
                matchingOpenBracket = stack.pop()
                if ((bracket == ')' and matchingOpenBracket != '(') or
                    (bracket == ']' and matchingOpenBracket != '[') or
                    (bracket == '}' and matchingOpenBracket != '{')):
                    return False

                
        return len(stack) == 0


    def isOpenBracket(self, bracket: str):
        return bracket in ['(', '[', '{']
