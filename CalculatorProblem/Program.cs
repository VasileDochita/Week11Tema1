using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProblem
{
    public class calculatorClass
    {
        public decimal Add(decimal a, decimal b)
        {
            decimal c = a + b;
            return c;
        }
        
        public decimal Substraction(decimal a, decimal b)
        {
            return a - b;
        }

        public decimal Divide(decimal a, decimal b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException(nameof(b));
            }

            return a / b;
        }
        public decimal Multiply(decimal a, decimal b)
        {
            return a * b;
        }
    }
}
