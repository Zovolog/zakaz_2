namespace Task3
{
    public class Program
    {
        static void Main(string[] args)
        {
            FunctionCache<string, int> cache = new FunctionCache<string, int>();

            FunctionCache<string, int>.Func<string, int> expensiveFunction = key =>
            {
                Console.WriteLine($"Розрахунок результату для ключа: {key}");
                return key.Length * 2;
            };

            int result1 = cache.GetOrAdd("test", expensiveFunction, TimeSpan.FromSeconds(5));
            Console.WriteLine($"Результат 1: {result1}");

            int result2 = cache.GetOrAdd("test", expensiveFunction, TimeSpan.FromSeconds(5));
            Console.WriteLine($"Результат 2: {result2}");

            int result3 = cache.GetOrAdd("exampleinput", expensiveFunction, TimeSpan.FromSeconds(5));
            Console.WriteLine($"Результат 3: {result3}");
        }
    }
}