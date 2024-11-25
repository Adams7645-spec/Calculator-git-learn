using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal interface IOperation
    {
        string Name { get; }
        double Execute (double a, double b);
    }
}
