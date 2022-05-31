namespace Second.Spec.Steps;

[Binding]
public sealed class GreeterStepDefinitions
{
    private readonly Greeter _greeter = new();
    private string? _name;
    private string _text = string.Empty;

    [Given(@"the user's name is (.*)")]
    public void GivenTheUsersNameIs(string name)
    {
        _name = name;
    }

    [When(@"greeting")]
    public void WhenGreeting()
    {
        _text = _name is null ? _greeter.Greet() : _greeter.Greet(_name);
    }

    [Then(@"the text should be ""(.*)""")]
    public void ThenTheTextShouldBe(string expected)
    {
        _text.Should().Be(expected);
    }
}
