using System;
using System.Collections.Generic;
using System.Text;

namespace Lab9
{
    class MyMath
    {
        double result;
        double operand1;
        double operand2;

        public void Multiply(double operand1, double operand2)
        {
            result = (operand1 * operand2);
        }

        public void Divide(double operand1, double operand2)
        {
            result = (operand1 / operand2);
        }

        public void Subtract(double operand1, double operand2)
        {
            result = (operand1 - operand2);
        }

        public void Add(double operand1, double operand2)
        {
            result = (operand1 + operand2);
        }

        public double GetResult()
        {
            return result;
        }
    }
}
