using System;
using NUnit.Framework;
using JenkinsDriverLicense;
using NUnit.Framework.Internal;

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
        [TestCase(4, 7, 11)]
        [TestCase(3.5, 6.2, 9.7)]
        public void TestAddMethod_withPositiveInputValues(double number1, double number2, double result)
        {
            uut.Accumulator = number1;
            Assert.That(uut.Add(number2), Is.EqualTo(result).Within(0.005));
        }

        [TestCase(-1, -1, -2)]
        [TestCase(3, -2.5, 0.5)]
        [TestCase(4, -5.6, -1.6)]
        [TestCase(-6, 3, -3)]
        public void TestAddMethod_withNegativeInputValues(double number1, double number2, double result)
        {
            uut.Accumulator = number1;
            Assert.That(uut.Add(number2), Is.EqualTo(result).Within(0.005));
        }





        [TestCase(3, 2, 1)]
        [TestCase(3.5, 2.5, 1)]
        [TestCase(0, 0, 0)]
        [TestCase(2, 4.3, -2.3)]
        [TestCase(4.5, 6.5, -2)]
        public void TestSubstractMethod_withPositiveInputValues(double number1, double number2, double result)
        {
            uut.Accumulator = number1;
            Assert.That(uut.Subtract(number2), Is.EqualTo(result).Within(0.005));
        }

        [TestCase(-3, 2, -5)]
        [TestCase(-3.5, 4.5, -8)]
        [TestCase(0, 0, 0)]
        [TestCase(-2, -4, 2)]
        [TestCase(2.4, -4, 6.4)]
        public void TestSubstractMethod_withNegativeInputValues(double number1, double number2, double result)
        {
            uut.Accumulator = number1;
            Assert.That(uut.Subtract(number2), Is.EqualTo(result).Within(0.005));
        }





        [TestCase(2, 3, 6)]
        [TestCase(3, 4, 12)]
        [TestCase(0, 5, 0)]
        [TestCase(4.5, 3.2, 14.4)]
        [TestCase(6.2, 3, 18.6)]
        public void TestMultiplyMethod_withPositiveInputValues(double number1, double number2, double result)
        {
            uut.Accumulator = number1;
            Assert.That(uut.Multiply(number2), Is.EqualTo(result).Within(0.005));
        }

        [TestCase(-2, 3, -6)]
        [TestCase(-2, -3, 6)]
        [TestCase(0, -3, 0)]
        [TestCase(-4.5, 3, -13.5)]
        [TestCase(-5.1, -2.8, 14.28)]
        public void TestMultiplyMethod_withNegativeInputValues(double number1, double number2, double result)
        {
            uut.Accumulator = number1;
            Assert.That(uut.Multiply(number2), Is.EqualTo(result).Within(0.005));
        }





        [TestCase(3, 2, 9)]
        [TestCase(2, 0, 1)]
        [TestCase(4, 3.6, 147.033)]
        public void TestPowerMethod_withPositiveInputValues(double number1, double exp, double result)
        {
            uut.Accumulator = number1;
            Assert.That(uut.Power(exp), Is.EqualTo(result).Within(0.005));
        }

        [TestCase(2, -3.5, 0.088)]
        [TestCase(-2, -2, 0.25)]
        [TestCase(-2, 0, 1)]
        [TestCase(-4, 2, 16)]
        public void TestPowerMethod_withNegativeInputValues(double number1, double exp, double result)
        {
            uut.Accumulator = number1;
            Assert.That(uut.Power(exp), Is.EqualTo(result).Within(0.005));
        }





        [TestCase(10, 5, 2)]
        [TestCase(10.25, 2.35, 4.3617)]
        [TestCase(2, 0, 0)]
        [TestCase(0, 2, 0)]
        public void TestDivide_PositiveInputValues(double number1, double number2, double result)
        {
            uut.Accumulator = number1;
            Assert.That(uut.Divide(number2), Is.EqualTo(result).Within(0.005));
        }

        [TestCase(-10, -5, 2)]
        [TestCase(10, -5, -2)]
        [TestCase(-10, -5, -2)]
        public void TestDivide_NegativeInputValues(double number1, double number2, double result)
        {
            uut.Accumulator = number1;
            Assert.That(uut.Divide(number2), Is.EqualTo(result).Within(0.005));
        }




        [TestCase(1, 0)]
        [TestCase(10, 1)]
        [TestCase(20, 1.301)]
        [TestCase(54.78, 1.739)]
        [TestCase(137.23, 2.137)]
        [TestCase(289.21, 2.461)]
        public void TestLog10method_withPositiveInputValues(double accumulator, double result)
        {
            uut.Accumulator = accumulator;
            Assert.That(uut.Log(), Is.EqualTo(result).Within(0.005));
        }



        [Test]
        public void TestPiMethod()
        {
            Assert.That(uut.Pi(),Is.EqualTo(Math.PI));
        }


        [Test]
        public void TestEuhlerMethod()
        {
            Assert.That(uut.Euler(), Is.EqualTo(Math.E));
        }

        [Test]
        public void TestClearMethod()
        {
            uut.Accumulator = 3;
            Assert.That(uut.Accumulator, Is.EqualTo(3));

            uut.Clear();
            Assert.That(uut.Accumulator, Is.EqualTo(0));
        }


        
        [TestCase(4, 2, 2)]
        public void Accumulator(double testNumber1, double testNumber2, double testNumber3)
        {
            uut.Accumulator = 1;
            
            double result1 = uut.Add(testNumber1);

            Assert.That(uut.Accumulator, Is.EqualTo(result1));

            double result2 = uut.Subtract(testNumber2);

            Assert.That(uut.Accumulator, Is.EqualTo(result2));

            double result3 = uut.Multiply(testNumber3);

            Assert.That(uut.Accumulator, Is.EqualTo(result3));
        }
    }

}