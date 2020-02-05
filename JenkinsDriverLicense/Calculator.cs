using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JenkinsDriverLicense
{
    public class Calculator
    {
        public double Add(double number1, double number2)
        {
            return number1 + number2;
        }

        public double Subtract(double number1, double number2)
        {
            return number1 - number2;
        }

        public double Multiply(double number1, double number2)
        {
            return number1 * number2;
        }

        public double Power(double number, double exp)
        {
            return Math.Pow(number, exp);
        }

        public double Divide(double number1, double number2)
        {
            return number1 / number2;
        }
    }
}
