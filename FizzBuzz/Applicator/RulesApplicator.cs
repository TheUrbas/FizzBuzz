using FizzBuzz.Rules;

namespace FizzBuzz.Applicator;

public class RulesApplicator(IEnumerable<IRule> rules)
{
    public IEnumerable<IRule> _rules = rules;

    public IEnumerable<string> ApplyRulesAndReturnList(IEnumerable<int> numbers)
    {
        return numbers.Select(GetRulesTransformation);
    }

    private string GetRulesTransformation(int number)
    {
        var transformedString = string.Join("", _rules.Select(rule => rule.isRuleValid(number) ? rule.applyTransformation(number) : ""));
        return string.IsNullOrEmpty(transformedString) ? number.ToString() : transformedString;
    }
}