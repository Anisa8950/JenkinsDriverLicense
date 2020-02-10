using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JenkinsDriverLicense
{
    public class OperatorController
    {
        private CalculatorMetods _metohds;

        public OperatorController(CalculatorMetods methods)
        {
            _metohds = methods;
        }

        public double Calculate(string op, double number2)
        {
            double result=0;

            switch (op)
            {
                case "+":
                    result=_metohds.Add(number2);
                    break;
                case "-":
                    result = _metohds.Subtract(number2);
                    break;
                case "x":
                    result = _metohds.Multiply(number2);
                    break;
                case "/":
                    result = _metohds.Divide(number2);
                    break;
            }

            return result;
        }
    }
}
