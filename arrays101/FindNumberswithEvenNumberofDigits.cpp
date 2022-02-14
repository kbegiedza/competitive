class Solution {
public:
    int findNumbers(vector<int>& nums) {
        int result = 0;
        int divCounter = 1;

        for (auto &&x : nums)
        {
            while (x > 9)
            {
                divCounter++;
                x /= 10;
            }
    
            if ((divCounter & 1) == 0)
            {
                result++;
            }
            
            divCounter = 1;
        }
        
        return result;
    }
};