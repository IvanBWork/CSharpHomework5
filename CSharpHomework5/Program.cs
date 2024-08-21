namespace CSharpHomework5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = 0;
            string? action = "";
            

            ICalculator calculator = new Calculator();
            calculator.GotResult += Calculator_GotResult;

            while (number != null)
            {
                Console.Write("Введите число: ");                
                string? input = Console.ReadLine();
                if (input.Equals("q") || input.Equals("")) return;
                
                number = ReadDouble(input);

                Console.Write("Введите арифметическое действие: ");
                action = Console.ReadLine();
                switch (action)
                {
                    case "+":
                        calculator.Sum(number);
                        break;
                    case "-":
                        calculator.Substract(number);
                        break;
                    case "*":
                        calculator.Multiply(number);
                        break;
                    case "/":
                        calculator.Divide(number);
                        break;
                    case "q":
                        return;                           
                    case "":
                        return;
                    default:
                        Console.WriteLine("Вы ввели неверное действие.");
                        Console.WriteLine();
                        break;
                }                               
            }
        }

        private static void Calculator_GotResult(object? sender, OperandChangedEventArgs e)
        {
            Console.WriteLine($"Итог: {e.Operand}");
            Console.WriteLine();
        }

        private static double ReadDouble(string? input)
        {            
            double i;
            while (!double.TryParse(input, out i))
            {                
                Console.WriteLine("Вы ввели не число!");
                input = Console.ReadLine();                
            }
            return i;
        }
    }
}
