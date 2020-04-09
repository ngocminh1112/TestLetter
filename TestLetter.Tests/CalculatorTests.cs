using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestLetter.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        Calculator cal;

        public CalculatorTests()
        {
            cal = new Calculator();
        }

        [TestMethod]
        public void Calculator_ABC()
        {
            var input = "abc";
            var actual = cal.LetterPoint(input);
            Assert.AreEqual(7, actual);
        }
    }
}
