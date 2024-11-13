using Api;

namespace Test;

public class EchoTests
{
    [Fact]
    public void EchoHello_WhenProvidedHello()
    {
        var logic = new Logic();
        Assert.Equal("Echo: Hello", logic.Echo("Hello"));
    }
}
