using System;
using DoubleCola;
using NUnit.Framework;

[TestFixture]
public class ListTests
{
    [Test]
    public void Test1()
    {
        string[] names = new string[] { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard" };
        int n = 1;
        Assert.AreEqual("Sheldon", Line.WhoIsNext(names, n));
    }

    [Test]
    public void Test2()
    {
        string[] names = new string[] { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard" };
        int n = 6;
        Assert.AreEqual("Sheldon", Line.WhoIsNext(names, n));
    }

    [Test]
    public void Test3()
    {
        string[] names = new string[] { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard" };
        long n = 7230702951;
        Assert.AreEqual("Leonard", Line.WhoIsNext(names, n));
    }

    [Test]
    public void Test4()
    {
        string[] names = new string[] { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard" };
        long n = 52;
        Assert.AreEqual("Penny", Line.WhoIsNext(names, n));
    }

    [Test]
    public void Test5()
    {
        string[] names = new string[] {  "Rajesh" };
        long n = 1;
        Assert.AreEqual("Rajesh", Line.WhoIsNext(names, n));
    }
}