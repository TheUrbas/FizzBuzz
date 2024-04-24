using FizzBuzz.Rules;

namespace FizzBuzz.Applicator;

public class RulesApplicator(IEnumerable<IRule> rules)
{
    public IEnumerable<IRule> _rules = rules;
}