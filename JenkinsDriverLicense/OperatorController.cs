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

        public double Calculate(string op, double number1, double number2)
        {
            switch (op)
            {
                case "+":
                    break;
                case "-":
                    break;
                case "x":
                    break;
                case "/":
                    break;
            }

            return 0;
        }
    }
}
