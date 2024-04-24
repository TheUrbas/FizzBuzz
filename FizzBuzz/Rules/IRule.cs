namespace FizzBuzz.Rules;

public interface IRule
{
    public bool isRuleValid(int number);
    public string applyTransformation(int number);
}