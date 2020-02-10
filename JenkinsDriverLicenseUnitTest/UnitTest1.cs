using NUnit.Framework;
using JenkinsDriverLicense;

namespace JenkinsDriverLicenseUnitTest
{
    public class Tests
    {
        private Calculator uut;

        [SetUp]
        public void Setup()
        {
            uut = new Calculator();
        }

        [TestCase(1, 1, 2)]
        [TestCase(1.5, 2.5, 4)]
        [TestCase(0, 0, 0)]
        [TestCase(-1, -1, -2)]
        [TestCase(-1, 3, 2)]
        public void Add(double number1, double number2, double result)
        {
            Assert.That(uut.Add(number1, number2), Is.EqualTo(result).Within(0.005));
        }

        [TestCase(3, 2, 1)]
        [TestCase(3.5, 2.5, 1)]
        [TestCase(0, 0, 0)]
        [TestCase(-2, -4, 2)]
        [TestCase(2, -4, 6)]
        public void Substract(double number1, double number2, double result)
        {
            Assert.That(uut.Subtract(number1, number2), Is.EqualTo(result).Within(0.005));
        }

        [TestCase(2, 3, 6)]
        [TestCase(-2, 3, -6)]
        [TestCase(2, -3, -6)]
        [TestCase(-2, -3, 6)]
        [TestCase(0, 3, 0)]
        public void Multiply(double number1, double number2, double result)
        {
            Assert.That(uut.Multiply(number1, number2), Is.EqualTo(result).Within(0.005));
        }

        [TestCase(3, 2, 9)]
        [TestCase(2, 0, 1)]
        public void Power(double number1, double exp, double result)
        {
            Assert.That(uut.Power(number1, exp), Is.EqualTo(result).Within(0.005));
        }
    }
}