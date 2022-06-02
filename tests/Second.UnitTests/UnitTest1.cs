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

    [Fact]
    public void Greeting_Is_Not_Empty()
    {
        // Arrange
        var greeter = new Greeter();

        // Act
        string response = greeter.Greet("Someone");

        // Assert
        response.Should().NotBeNullOrEmpty();
    }
}
