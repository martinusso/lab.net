using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using CheckDigit;

namespace CheckDigit.Tests
{
    [TestClass]
    public class Modulus11Tests
    {
        [TestMethod]
        public void TestShouldReturnCorrectCheckDigit()
        {
            string number;
            string expectedCheckDigit;
            string checkdigit;

            number = "3214020082778300190055001000005971122014397";
            expectedCheckDigit = "4";
            var mod11 = new Modulus11();
            checkdigit = mod11.GetCheckDigit(number);
            Assert.AreEqual(expectedCheckDigit, checkdigit);

            number = "3214041306259400010755001000001039113062594";
            expectedCheckDigit = "7";
            checkdigit = mod11.GetCheckDigit(number);
            Assert.AreEqual(expectedCheckDigit, checkdigit);
        }
    }
}