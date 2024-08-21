using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHomework5
{
    internal interface ICalculator
    {
        void Sum(double x);
        void Substract(double x);
        void Divide(double x);
        void Multiply(double x);
        void CancelLast();

        event EventHandler<OperandChangedEventArgs> GotResult;
    }
}
