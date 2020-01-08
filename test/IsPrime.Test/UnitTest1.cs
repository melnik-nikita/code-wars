namespace Solution
{
    using System.Collections.Generic;
    using System;
    using IsPrime;
    using NUnit.Framework;

    [TestFixture]
    public class SolutionTest
    {
        private static IEnumerable<TestCaseData> sampleTestCases
        {
            get
            {
                yield return new TestCaseData(0).Returns(false);
                yield return new TestCaseData(1).Returns(false);
                yield return new TestCaseData(2).Returns(true);
            }
        }

        [Test, TestCaseSource("sampleTestCases")]
        public bool SampleTest(int n) => Kata.IsPrime(n);
    }
}