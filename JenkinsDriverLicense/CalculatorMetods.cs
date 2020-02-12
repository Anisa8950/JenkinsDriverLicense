using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JenkinsDriverLicense
{
    public class CalculatorMetods
    {
        public double Accumulator { get; set; }


        public CalculatorMetods()
        {
            Accumulator = 0;
        }

        public void Clear()
        {
            Accumulator = 0;
        }

        public double Add(double number1, double number2)
        {
            double result = number1 + number2;
            Accumulator = result;
            return result;
        }

        public double Subtract(double number1, double number2)
        {
            double result = number1 - number2;
            Accumulator = result;
            return result;
        }

        public double Multiply(double number1, double number2)
        {
            double result = number1 * number2;
            Accumulator = result;
            return result;
        }

        public double Power(double number1, double exp)
        {
            double result = Math.Pow(number1, exp);
            Accumulator = result;
            return result;
        }

        public double Divide(double dividend,double divisor)
        {
            double result = dividend / divisor;
            Accumulator = result;
            return result;
        }

        public double Add(double number2)
        {
            double result = Accumulator + number2;
            Accumulator = result;
            return result;
        }


        public double Subtract(double number2)
        {
            double result = Accumulator - number2;
            Accumulator = result;
            return result;
        }

        public double Multiply(double number2)
        {
            double result = Accumulator * number2;
            Accumulator = result;
            return result;
        }

        public double Power(double exp)
        {
            double result = Math.Pow(Accumulator, exp);
            Accumulator = result;
            return result;
        }

        public double Divide(double divisor)
        {
            double result = Accumulator / divisor;
            Accumulator = result;
            return result;
        }

        public double Log()
        {
            double result = Math.Log10(Accumulator);
            Accumulator = result;
            return result;
        }

        public double Pi()
        {
            return Math.PI;
        }

        public double Euler() 
        {
            return Math.E;
        }
    }
}
