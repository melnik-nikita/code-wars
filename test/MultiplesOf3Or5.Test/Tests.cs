using MultiplesOf3Or5;
using NUnit.Framework;

[TestFixture]
public class Tests
{
    [Test]
    public void Test()
    {
        Assert.AreEqual(23, Kata.Solution(10));
    }
}