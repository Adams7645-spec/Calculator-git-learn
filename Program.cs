using Calculator.Operations;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();

            //  Standart operation
            calculator.AddOperation(new Addition());
            calculator.AddOperation(new Subtraction());

            //  Add new operations by yourself 
            //calculator.AddOperation(new Multiplication());

            //  How to use
            Console.WriteLine("Input first digit:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Input second digit:");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Select opetation (add, subtract, multiply):");
            string operation = Console.ReadLine();

            try
            {
                double result = calculator.ExecuteOperation(operation, a, b);
                Console.WriteLine($"Результат: {result}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
