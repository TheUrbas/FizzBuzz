namespace FizzBuzz.Rules;

public class FizzRule : IRule
{
    public bool isRuleValid(int number)
    {
        return number % 3 == 0;
    }

    public string applyTransformation(int number)
    {
        return "Fuzz";
    }
}