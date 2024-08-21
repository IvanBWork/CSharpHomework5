using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHomework5
{
        public class OperandChangedEventArgs(double operand) : EventArgs
        {
            public double Operand => operand;
        }
}
