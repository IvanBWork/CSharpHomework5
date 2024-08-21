using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHomework5
{
    internal class Calculator : ICalculator
    {
        public event EventHandler<OperandChangedEventArgs> GotResult;
        private Stack<double> stack = new Stack<double>();
        private double Result { 
            get 
            {
                return stack.Count() == 0 ? 0 : stack.Peek();
            } 
            set 
            { 
                stack.Push(value); 
                RaiseEvent(); 
            } 
        }
        public void RaiseEvent()
        {
            GotResult.Invoke(this, new OperandChangedEventArgs(Result));
        }
        public void CancelLast() 
        {
            if (stack.Count > 0)
            {
                stack.Pop();
                RaiseEvent();
            }
        }
        public void Divide(double number)
        {
             Result /= number;
        }

        public void Multiply(double number)
        {
             Result *= number;
        }

        public void Substract(double number)
        {
             Result -= number;
        }

        public void Sum(double number)
        {
             Result += number;
        }
        
    }
}
