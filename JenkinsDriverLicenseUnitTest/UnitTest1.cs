using System;
using NUnit.Framework;
using JenkinsDriverLicense;

namespace JenkinsDriverLicenseUnitTest
{
    public class Tests
    {
        private CalculatorMetods uut;

        [SetUp]
        public void Setup()
        {
            uut = new CalculatorMetods();
        }

        [TestCase(1, 1, 2)]
        [TestCase(1.5, 2.5, 4)]
        [TestCase(0, 0, 0)]
        [TestCase(-1, -1, -2)]
        [TestCase(-1, 3, 2)]
        public void Add(double number1, double number2, double result)
        {
            uut.Accumulator = number1;
            Assert.That(uut.Add(number2), Is.EqualTo(result).Within(0.005));
        }

        [TestCase(3, 2, 1)]
        [TestCase(3.5, 2.5, 1)]
        [TestCase(0, 0, 0)]
        [TestCase(-2, -4, 2)]
        [TestCase(2, -4, 6)]
        public void Substract(double number1, double number2, double result)
        {
            uut.Accumulator = number1;
            Assert.That(uut.Subtract(number2), Is.EqualTo(result).Within(0.005));
        }

        [TestCase(2, 3, 6)]
        [TestCase(-2, 3, -6)]
        [TestCase(2, -3, -6)]
        [TestCase(-2, -3, 6)]
        [TestCase(0, 3, 0)]
        public void Multiply(double number1, double number2, double result)
        {
            uut.Accumulator = number1;
            Assert.That(uut.Multiply(number2), Is.EqualTo(result).Within(0.005));
        }

        [TestCase(3, 2, 9)]
        [TestCase(2, 0, 1)]
        public void Power(double number1, double exp, double result)
        {
            uut.Accumulator = number1;
            Assert.That(uut.Power(exp), Is.EqualTo(result).Within(0.005));
        }

        [TestCase(10, 5, 2)]
        [TestCase(4, 2, 2)]
        [TestCase(8, 2, 4)]

        public void Divide(double number1, double number2, double result)
        {
            uut.Accumulator = number1;
            Assert.That(uut.Divide(number2), Is.EqualTo(result).Within(0.005));

        }

        [Test]

        public void Pi()
        {
            Assert.That(uut.Pi(),Is.EqualTo(Math.PI));

        }

        [Test]
        public void Euler()
        {
            double result = uut.Euler();

            Assert.That(result, Is.EqualTo(Math.E));
        }


    }

}