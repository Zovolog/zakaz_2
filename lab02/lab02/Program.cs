namespace Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Calculator<int> intCalculator = new Calculator<int>();
            Console.WriteLine($"Додавання: {intCalculator.PerformAddition(5, 3)}");
            Console.WriteLine($"Віднімання: {intCalculator.PerformSubtraction(5, 3)}");
            Console.WriteLine($"Множення: {intCalculator.PerformMultiplication(5, 3)}");
            Console.WriteLine($"Ділення: {intCalculator.PerformDivision(6, 2)}");

            Calculator<double> doubleCalculator = new Calculator<double>();
            Console.WriteLine($"Додавання: {doubleCalculator.PerformAddition(5.5, 3.2)}");
            Console.WriteLine($"Віднімання: {doubleCalculator.PerformSubtraction(5.5, 3.2)}");
            Console.WriteLine($"Множення: {doubleCalculator.PerformMultiplication(5.5, 3.2)}");
            Console.WriteLine($"Ділення: {doubleCalculator.PerformDivision(6.0, 2.0)}");
        }
    }
}