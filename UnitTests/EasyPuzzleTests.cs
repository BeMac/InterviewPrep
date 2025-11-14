

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
    
    [Fact]
    public void ProcessCouponStackOperations_Pass()
    {
        var operations = new List<string>();
        operations.AddRange("push 2", "push 0", "push 3", "push 0", "getMin", "pop", "getMin", "pop", "top", "getMin");

        var expected = new List<int>{0, 0, 0, 0};
         
        var happy = EasyPuzzles.ProcessCouponStackOperations(operations);
        
        Assert.Equal(happy, expected);
    }
    
    [Fact]
    public void CountResponseTimeRegressions()
    {
        var responseTimes = new List<int> { 100, 200, 150,300 };
        var expected = 2;
        var happy = EasyPuzzles.CountResponseTimeRegressions(responseTimes);
        
        Assert.Equal(happy, expected);
    }
}