namespace Second.UnitTests;

public class UnitTest1
{
    [Fact]
    public void Test_That_Always_Passes_When_True()
    {
        true.Should().BeTrue();
    }

    [Fact]
    public void Test_That_Always_Passes_When_False()
    {
        false.Should().BeFalse();
    }

    [Theory]
    [InlineData(null)]
    [InlineData("Someone")]
    public void Greeting_Is_Not_Empty(string? name)
    {
        // Arrange
        var greeter = new Greeter();

        // Act
        string response = greeter.Greet(name);

        // Assert
        response.Should().NotBeNullOrEmpty();
    }
}
