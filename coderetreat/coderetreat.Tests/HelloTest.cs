using be.swsb.coderetreat;

namespace coderetreat.Tests;

public class HelloTest
{
    [Fact]
    public void Greet_Should_Return_World()
    {
        Assert.Equal("World!", new Hello().Greet());
    }
}