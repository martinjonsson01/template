namespace First.UnitTests;

public class UnitTest1
{
    private readonly Calculator _calculator = new ();

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
    public void Adding_Zero_Does_Not_Change_The_Number()
    {
        // Arrange
        const int number = 12;
        _calculator.FirstNumber = number;
        _calculator.SecondNumber = 0;

        // Act
        int result = _calculator.Add();

        // Assert
        result.Should().Be(number);
    }

    [Fact]
    public void Subtracting_Zero_Does_Not_Change_The_Number()
    {
        // Arrange
        const int number = 12;
        _calculator.FirstNumber = number;
        _calculator.SecondNumber = 0;

        // Act
        int result = _calculator.Subtract();

        // Assert
        result.Should().Be(number);
    }
}
