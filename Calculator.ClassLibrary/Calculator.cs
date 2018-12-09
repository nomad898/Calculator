using Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.ClassLibrary
{
    public class Calculator : ICalculator
    {
        public IOperation Operation { get; set; }

        public Calculator(IOperation operation)
        {
            this.Operation = operation;
        }

        public double CallOperation()
        {
            return Operation.Execute();
        }
    }
}
