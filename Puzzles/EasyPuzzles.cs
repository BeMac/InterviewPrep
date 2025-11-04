
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
    
    //implements 4 actions. Push, Pop, Top, GetMin.
    //push requires an int value and pushes it to the end of the a temp stack.
    //pop removes the top element from the temp stack
    //Top adds the "top" value from the temp stack to the return object.
    //getMin adds the minimum value from the temp stack to the return object. 
    public static List<int> ProcessCouponStackOperations(List<string> operations)
    {
        List<int> returnList = new List<int>();
        List<int> tempStack = new List<int>();
        foreach (var operation in operations)
        {
            string[] verb = operation.Split(' ', 2);
            switch (verb[0])
            {
                case "push":
                    int happy = int.Parse(verb[1]);
                    tempStack.Add(happy);
                    break;
                case "pop":
                    if (tempStack.Count > 0)
                    {
                        tempStack.RemoveAt(tempStack.Count - 1);    
                    }
                    break;
                case "top":
                    if (tempStack.Count > 0)
                    {
                        returnList.Add(tempStack.Last());    
                    }
                    break;
                case "getMin":
                    if (tempStack.Count > 0)
                    {
                        returnList.Add(tempStack.Min());    
                    }
                    break;
            }
            
        }

        return returnList;
    }
}

