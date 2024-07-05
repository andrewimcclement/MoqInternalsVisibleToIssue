using Moq;

namespace Production.Tests;

internal class InternalsVisibleToTests
{
    [Test]
    public void SucceedsOnAllFrameworks()
    {
        var obj = new Mock<InternalDerivedClass>();
        Assert.That(obj.Object.Bar(), Is.Null);
        obj.Setup(x => x.Bar()).Returns("Baz");
        var result = obj.Object.Bar();
        Assert.That(result, Is.EqualTo("Baz"));
    }

    [Test]
    public void FailsOnNetCoreMinimalRepro()
    {
        var obj = new Mock<DerivedControlInSameAssembly>();
        Assert.That(() => obj.Object, Throws.Nothing);
    }

    [Test]
    public void FailsOnNetCore()
    {
        var obj = new Mock<DerivedControlInSameAssembly>();
        Assert.That(() => obj.Object, Throws.Nothing);
    }

    [Test]
    public void MockControlSucceedsOnAllFrameworks()
    {
        var foo = new Mock<Control>();
        Assert.That(() => foo.Object, Throws.Nothing);
    }
}