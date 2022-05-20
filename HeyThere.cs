using FluentAssertions;

namespace studious_barnacle;

public class HeyThere
{
    public string HelloWorld => "Hello World!";

    public string HelloAny(string name) => $"Hello {name}";

#if DEBUG

    [Fact]
    public void HelloTest() => this.HelloWorld.Should().Be("Hello World!");

    [Theory]
    [InlineData("walt")]
    [InlineData("Kimberly")]
    public void HelloName(string name) => this.HelloAny(name).Should().Be($"Hello {name}");

#endif
}
