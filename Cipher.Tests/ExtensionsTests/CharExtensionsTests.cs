using Cipher.Logic;

namespace Cipher.Tests.ExtensionsTests;

public class CharExtensionsTests
{
    [Theory]
    [InlineData('a', 'b')]
    public void Test1(char a, char b)
    {
        var c = a.JumpLetter(1);
        Assert.Equal(b, c);
    }
}
