using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CalculatorDLL;

namespace CalculatorTests
{
    [TestClass]
    public class UnitTest1
    {
        private static readonly double Delta = 0.00001;

        [TestMethod]
        public void AddTest()
        {
            // AddTest integer
            Assert.AreEqual(12, Calculator.Addition(7, 5));
            // AddTest double
            Assert.AreEqual(20.0, Calculator.Addition(11.0, 9.0));
        }

        [TestMethod]
        public void SubtractTest()
        {
            // SubTest integer
            Assert.AreEqual(5, Calculator.Subtraction(9, 4));
            // SubTest double
            Assert.AreEqual(10.0, Calculator.Subtraction(20, 10));
        }

        [TestMethod]
        public void MultiplyTest()
        {
            // MultiplyTest integer
            Assert.AreEqual(20, Calculator.Multiplication(4, 5));
            // MultiplyTest double
            Assert.AreEqual(100.0, Calculator.Multiplication(10.0, 10.0));
        }

        [TestMethod]
        public void DivisionTest()
        {
            // DivisionTest integer
            Assert.AreEqual(4, Calculator.Divide(20, 5));
            // DivisionTest double
            Assert.AreEqual(5.0, Calculator.Divide(100.0, 20.0));
        }
    }
}
