

public class MediumPuzzleTests
{
    [Fact]
    public void LongestCommonPrefix_FL()
    {
        string[] strings = ["flower", "flow", "flight"];
        var returnValue = MediumPuzzles.LongestCommonPrefix(strings);
        Assert.Equal(returnValue, "fl");
    }
    
    [Fact]
    public void LongestCommonPrefix_Empty()
    {
        string[] strings = ["dog","racecar","car"];
        var returnValue = MediumPuzzles.LongestCommonPrefix(strings);
        
        Assert.Equal(returnValue, "");
    }
    
}