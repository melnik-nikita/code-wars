using System;
using DoubleCola;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard" };
            long n = 1;

            // Assert.AreEqual("Sheldon", Line.WhoIsNext(names, n));
            Console.WriteLine(Line.WhoIsNext(names, n));

            n = 6;
            // Assert.AreEqual("Sheldon", Line.WhoIsNext(names, n));
            Console.WriteLine(Line.WhoIsNext(names, n));

            n = 52;
            // Assert.AreEqual("Penny", Line.WhoIsNext(names, n));
            Console.WriteLine(Line.WhoIsNext(names, n));

            n = 1;
            // Assert.AreEqual("Rajesh", Line.WhoIsNext(names, n));
            // string[] rajesh = new string[] { "Rajesh" };
            Console.WriteLine(Line.WhoIsNext(new string[] { "Rajesh" }, n));

            // n = 7230702951;
            // // Assert.AreEqual("Sheldon", Line.WhoIsNext(names, n));
            // Line.WhoIsNext(names, n);
        }
    }
}