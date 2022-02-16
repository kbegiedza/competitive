class Solution {
public:
    int findMaxConsecutiveOnes(vector<int>& nums) {
        int maxCounter = 0;
        int counter = 0;

        for (int i = 0; i < nums.size(); ++i)
        {
            int value = nums[i];
            if (value == 0)
            {
                if (counter > maxCounter)
                {
                    maxCounter = counter;
                }

                counter = 0;
            }
            else
            {
                counter++;
            }
        }
        
        if (maxCounter > counter)
        {
            return maxCounter;
        }
        
        return counter;
    }
};