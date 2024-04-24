using FizzBuzz.Applicator;
using FizzBuzz.Rules;

var fizzRule = new FizzRule();
var buzzRule = new BuzzRule();

var applicator = new RulesApplicator(new List<IRule> { fizzRule, buzzRule });

var numbers = Enumerable.Range(1,100).ToList();

foreach (var result in applicator.ApplyRulesAndReturnList(numbers))
{
    Console.WriteLine(result);
}
