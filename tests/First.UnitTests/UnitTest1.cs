namespace First.UnitTests;

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
}
