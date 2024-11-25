using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Calculator
    {
        private readonly Dictionary<string, IOperation> _operations = new Dictionary<string, IOperation>();

        public void AddOperation(IOperation operation)
        {
            _operations[operation.Name] = operation;
        }

        public double ExecuteOperation(string operationName, double a, double b)
        {
            if (_operations.TryGetValue(operationName, out var operation))
            {
                return operation.Execute(a, b);
            }
            throw new InvalidOperationException($"Operation '{operationName}' not found.");
        }
    }
}
