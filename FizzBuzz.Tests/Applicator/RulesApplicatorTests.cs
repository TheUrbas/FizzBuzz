using FizzBuzz.Applicator;
using FizzBuzz.Rules;
using Moq;

namespace FizzBuzz.Tests.Applicator;

public class RulesApplicatorTests
{

    [Fact]
    public void ApplyRulesAndReturnLists_GivenFalseRule_ReturnsUnchangedListOfString()
    {
        var mockRule = new Mock<IRule>();
        mockRule.Setup(rule => rule.isRuleValid(It.IsAny<int>())).Returns(false);
        
        var applicator = new RulesApplicator(new List<IRule> { mockRule.Object });
        var inputList = new List<int> { 1, 2, 3 };
        var expectedOutputList = inputList.Select(item => item.ToString());

        var result = applicator.ApplyRulesAndReturnList(inputList);
        
        Assert.Equal(expectedOutputList, result);
    }
    
    [Fact]
    public void ApplyRulesAndReturnLists_GivenTrueRule_ReturnsTransformedListOfString()
    {
        var mockRule = new Mock<IRule>();
        mockRule.Setup(rule => rule.isRuleValid(It.IsAny<int>())).Returns(true);
        mockRule.Setup(rule => rule.applyTransformation(It.IsAny<int>())).Returns("test");
        
        var applicator = new RulesApplicator(new List<IRule> { mockRule.Object });
        var inputList = new List<int> { 1, 2, 3 };
        var expectedOutputList = new List<string> { "test", "test", "test" };

        var result = applicator.ApplyRulesAndReturnList(inputList);
        
        Assert.Equal(expectedOutputList, result);
    }
}