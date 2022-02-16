class Solution {
public:
    vector<int> sortedSquares(vector<int>& nums) {
        std::stack<int> negativeStack;
        std::queue<int> positiveQueue;

        std::vector<int> result;
        
        for (auto && num : nums)
        {
            if (num < 0)
            {
                negativeStack.push(num);
            }
            else
            {
                positiveQueue.push(num);
            }
        }

        while(!negativeStack.empty() || !positiveQueue.empty())
        {
            if(negativeStack.empty())
            {
                int positive = positiveQueue.front();

                positiveQueue.pop();
                result.push_back(positive * positive);
            }
            else if(positiveQueue.empty())
            {
                int negative = negativeStack.top();
            
                negativeStack.pop();
                result.push_back(negative * negative);
            }
            else
            {
                int negative = negativeStack.top();
                int positive = positiveQueue.front();
            
                int negativeAsPositive = -negative;
            
                if(positive < negativeAsPositive)
                {
                    positiveQueue.pop();
                    result.push_back(positive * positive);
                }
                else
                {
                    negativeStack.pop();
                    result.push_back(negativeAsPositive * negativeAsPositive);
                }
            }
        }
        
        return result;
    }
};