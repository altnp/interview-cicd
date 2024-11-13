using Api;

namespace Test;

public class UnitTest1
{
    [Fact]
    public void EchoHello_WhenProvidedHello()
    {
        var logic = new Logic();
        Assert.Equal("Echo: Hello", logic.Echo("Hello"));
    }
}
