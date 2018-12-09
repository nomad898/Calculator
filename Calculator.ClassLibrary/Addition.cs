using Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.ClassLibrary
{
    public class Addition : IOperation
    {
        private readonly double firstNumber;
        private readonly double secondNumber;

        public Addition(double firstNumber, double secondNumber)
        {
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
        }        

        public double Execute()
        {
            return Add();
        }

        private double Add()
        {
            return firstNumber + secondNumber;
        }
    }
}
