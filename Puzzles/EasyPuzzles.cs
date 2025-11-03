
public class EasyPuzzles
{
    
    //Given a sorted array of positive integers and a target value, count the number of pairs (i, j) where i < j and array[i] + array[j] <= target.
    //input: prices = [1, 2, 3, 4, 5]
            //budget = 7
            
    //output: 8
        
    public static int CountAffordablePairs(List<int> prices, int budget)
    {
        var length = prices.Count -1; //4
        int validPairs = 0;
        for(int lowerBound = 0; lowerBound < length; lowerBound ++)
        {
            for (int upperBound = lowerBound + 1; upperBound <= length; upperBound++)
            {
                if(prices[lowerBound] + prices [upperBound] <= budget)
                {
                    validPairs ++;
                }    
            }
        }
        
        return validPairs;

    }
    
    /*
     * Complete the 'findFirstOccurrence' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY nums
     *  2. INTEGER target
     */
    public static int FindFirstOccurrence(List<int> nums, int target)
    {
        for (int index = 0; index <= nums.Count -1; index++)
        {
            if (nums[index] == target)
            {
                return index;
            }
            
        }

        return -1;

    }
}

