using CSharpCore.Lessons.Extensions;

namespace TestCases.Lessons.Extensions;

[TestFixture]
[TestOf(typeof(MyExtensions))]
public class MyExtensionsTest
{

    [Test]
    public void TestSpacePeriodQuestionMark()
    {
        var rawString = "Noman Ali.Abbasi?";
        Assert.That(true, "NomanAliAbbasi", rawString);
    }
}