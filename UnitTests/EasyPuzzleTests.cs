

public class EasyPuzzleTests
{
    [Fact]
    public void CountAffordablePairs_Pass()
    {
        List<int> prices = [1, 2, 3, 4, 5];
        int budget = 7;
        int expected = 8;
        var happy = EasyPuzzles.CountAffordablePairs(prices, budget);
        
        Assert.Equal(happy, expected);
    }

    [Fact]
    public void FindFirstOccurrence_Pass()
    {
        List<int> nums = [1, 2, 3, 4, 5];
        int target = 3;
        int expected = 2;
        var happy = EasyPuzzles.FindFirstOccurrence(nums, target);
        
        Assert.Equal(happy, expected);
    }

}