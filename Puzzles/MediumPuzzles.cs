
public class MediumPuzzles
{
    
    //Method returns the longest common prefix for all the strings that are passed into it. 
    //if there is no common prefix, it simply returns an empty string. 
    
    public static string LongestCommonPrefix(string[] strs)
    {
        string returnPrefix = string.Empty;
        string firstWord = strs[0];
        int longestCommonPrefix = 0;
        for (int outerIndex = 1; strs.Length > outerIndex; outerIndex++)
        {
            if (firstWord[0] != strs[outerIndex][0])
            {
                return string.Empty;
            }
            int wordMatch = 0;
            for (int innerIndex = 0; strs[outerIndex].Length > innerIndex; innerIndex++)
            {
                if (firstWord[innerIndex] == strs[outerIndex][innerIndex])
                {
                    wordMatch++;
                }
                else
                {
                    break;
                }
            }

            if (wordMatch < longestCommonPrefix)
            {
                longestCommonPrefix = wordMatch;
            }
            else
            {
                longestCommonPrefix = wordMatch;
            }
        }

        for (int index = 0; index < longestCommonPrefix; index++)
        {
            returnPrefix += firstWord[index];
        }
        
        return returnPrefix;
    }
    
}

