using Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.ClassLibrary
{
    public class Radical : IOperation
    {
        private readonly double number;
        private readonly double degree;

        public Radical(double number, double degree)
        {
            this.number = number;
            this.degree = 1 / degree;
        }
        public double Execute()
        {
            return FindRadical();
        }

        private double FindRadical()
        {
            return Math.Pow(number, degree);
        }
    }
}
