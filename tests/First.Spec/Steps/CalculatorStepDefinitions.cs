namespace First.Spec.Steps;

// For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
[Binding]
public sealed class CalculatorStepDefinitions
{
    private readonly Calculator _calculator = new();

    private readonly ScenarioContext _scenarioContext;
    private int _result;

    public CalculatorStepDefinitions(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }

    [Given("the first number is (.*)")]
    public void GivenTheFirstNumberIs(int number)
    {
        _calculator.FirstNumber = number;
    }

    [Given("the second number is (.*)")]
    public void GivenTheSecondNumberIs(int number)
    {
        _calculator.SecondNumber = number;
    }

    [When("the two numbers are added")]
    public void WhenTheTwoNumbersAreAdded()
    {
        _result = _calculator.Add();
    }

    [When(@"the two numbers are subtracted")]
    public void WhenTheTwoNumbersAreSubtracted()
    {
        _result = _calculator.Subtract();
    }

    [Then("the result should be (.*)")]
    public void ThenTheResultShouldBe(int expected)
    {
        _result.Should().Be(expected);
    }
}
