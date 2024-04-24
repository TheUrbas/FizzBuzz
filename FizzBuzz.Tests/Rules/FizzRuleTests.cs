using FizzBuzz.Rules;

namespace FizzBuzz.Tests.Rules;

public class FizzRuleTests
{
    [Fact]
    public void isRuleValid_GivenValidValue_ReturnsTrue()
    {
        var fizzRule = new FizzRule();

        var result = fizzRule.isRuleValid(3);
        
        Assert.True(result);
    }
    
    [Fact]
    public void isRuleValid_GivenInvalidValue_ReturnsFalse()
    {
        var fizzRule = new FizzRule();

        var result = fizzRule.isRuleValid(2);
        
        Assert.False(result);
    }
    
    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(-1)]
    [InlineData(3)]
    public void applyTransformation_GivenAnyNumber_ReturnsFuzz(int number)
    {
        var fizzRule = new FizzRule();

        var result = fizzRule.applyTransformation(number);
        
        Assert.Equal("Fuzz", result);
    }
}