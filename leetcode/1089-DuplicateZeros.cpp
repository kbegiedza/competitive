class Solution {
public:
    void duplicateZeros(vector<int>& arr) {
        int newSize, startSize = newSize = arr.size();

        for(auto && x : arr)
        {
            if (x == 0)
            {
                newSize++;
            }
        }
        
        int elementIndex = arr.size() - 1;
        int insertIndex = arr.size() - 1;
        
        while (insertIndex > -1)
        {
            if (newSize > startSize)
            {
                if (arr[elementIndex] == 0)
                {
                    arr[elementIndex] = -1;
                }
                else
                {
                    elementIndex--;
                }
                
                newSize--;
            }
            else
            {
                auto element = arr[elementIndex];
                
                if (element == 0)
                {
                    arr[insertIndex] = element;

                    insertIndex--;
                    arr[insertIndex] = 0;
                }
                else if(arr[elementIndex] == -1)
                {
                    arr[insertIndex] = 0;
                }
                else
                {
                    arr[insertIndex] = element;
                }
    
                insertIndex--;
                elementIndex--;
            }
        }
    }
};