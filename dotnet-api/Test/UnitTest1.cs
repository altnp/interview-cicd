using Api;

namespace Test;

public class UnitTest1
{
    [Fact]
    public void Weather()
    {
        var logic = new Logic();
        Assert.Equal("Echo: Hello", logic.Echo("Hello"));
    }
}
