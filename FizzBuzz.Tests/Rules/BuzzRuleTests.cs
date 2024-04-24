namespace FizzBuzz.Tests.Rules;

public class BuzzRuleTests
{
    [Fact]
    public void isRuleValid_GivenValidValue_ReturnsTrue()
    {
        var fizzRule = new BuzzRule();

        var result = fizzRule.isRuleValid(5);
        
        Assert.True(result);
    }
    
    [Fact]
    public void isRuleValid_GivenInvalidValue_ReturnsFalse()
    {
        var fizzRule = new BuzzRule();

        var result = fizzRule.isRuleValid(2);
        
        Assert.False(result);
    }
    
    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(-1)]
    [InlineData(3)]
    public void applyTransformation_GivenAnyNumber_ReturnsBuzz(int number)
    {
        var fizzRule = new BuzzRule();

        var result = fizzRule.applyTransformation(number);
        
        Assert.Equal("Buzz", result);
    }
}