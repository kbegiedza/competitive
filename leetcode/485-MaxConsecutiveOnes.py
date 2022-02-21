class Solution:
    def findMaxConsecutiveOnes(self, nums: List[int]) -> int:
        longest = 0
        current = 0
        
        for index, item in enumerate(nums):
            if item == 1:
                current += 1
            
            if item == 0:
                longest = current if longest < current else longest
                current = 0
 
        longest = current if longest < current else longest

        return longest