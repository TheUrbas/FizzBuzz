namespace FizzBuzz.Rules;

public class BuzzRule
{
    public bool isRuleValid(int number)
    {
        return number % 5 == 0;
    }

    public string applyTransformation(int number)
    {
        return "Buzz";
    }
}