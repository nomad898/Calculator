using Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Calculator.ClassLibrary
{
    public class Multiplication : IOperation
    {
        private double first;
        private double second;

        public Multiplication(double first, double second)
        {
            this.first = first;
            this.second = second;
        }

        public double Execute()
        {
            return Multiply();
        }

        private double Multiply()
        {
            return first * second;
        }
    }
}