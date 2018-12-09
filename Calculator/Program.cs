using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.ClassLibrary;
using Calculator.Interfaces;

namespace Calculator.App
{
    class Program
    {
        static void Main(string[] args)
        {
            IOperation operation = new Radical(16, 2);
            ICalculator calculator = new ClassLibrary.Calculator(operation);
            Console.WriteLine(calculator.CallOperation());
            Console.ReadKey(true);         
        }
    }
}
