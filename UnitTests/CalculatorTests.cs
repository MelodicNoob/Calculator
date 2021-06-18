using System;
using NUnit.Framework;
using CoreLibrary;

namespace UnitTests
{
    public class CalculatorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Add_Num1_10_Num2_10_Returns20()
        {
            int num1 = 10;
            int num2 = 10;

            int result = Calculator.Add(num1, num2);

            Assert.AreEqual(20, result);
        }

        [Test]
        public void Minus_Num1_150_Num2_50_Returns100()
        {
            int num1 = 150;
            int num2 = 50;

            int result = Calculator.Minus(num1, num2);

            Assert.AreEqual(100, result);
        }

        [Test]
        public void Multiply_Num1_30_Num2_5_Returns150()
        {
            int num1 = 30;
            int num2 = 5;

            int result = Calculator.Multiply(num1, num2);

            Assert.AreEqual(150, result);
        }

        [Test]
        public void Divide_Num1_20_Num2_10_Returns2()
        {
            int num1 = 20;
            int num2 = 10;

            int result = Calculator.Divide(num1, num2);

            Assert.AreEqual(2, result);
        }

        [Test]
        public void Divide_Num1_50_Num2_10_Returns5()
        {
            int num1 = 50;
            int num2 = 10;

            int result = Calculator.Divide(num1, num2);

            Assert.AreEqual(5, result);
        }

        [Test]
        public void Divide_Num1_0_Num2_50_ThrowsDivideByZeroException()
        {
            int num1 = 0;
            int num2 = 50;

            var caughtException = Assert.Throws<DivideByZeroException>(() => Calculator.Divide(num1, num2));

            Assert.AreEqual("Attempted to divide by zero.", caughtException.Message);
        }

        [Test]
        public void Modulus_Num1_50_Num2_5_ReturnO()
        {
            int num1 = 50;
            int num2 = 5;

            int result = Calculator.Modulus(num1, num2);

            Assert.AreEqual(0, result);
        }

        [Test]
        public void Modulus_Num1_23_Num2_5_Returns3()
        {
            int num1 = 23;
            int num2 = 5;

            int result = Calculator.Modulus(num1, num2);

            Assert.AreEqual(3, result);
        }
    }
}