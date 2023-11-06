namespace Task2
{
    public delegate bool Criteria<T>(T item);

    public class Program
    {
        static void Main(string[] args)
        {
            Repository<string> stringRepository = new Repository<string>();
            stringRepository.Add("Audi");
            stringRepository.Add("BMW");
            stringRepository.Add("Mercedes");
            stringRepository.Add("Bentley");

            Criteria<string> criteria = s => s.Length <= 5;
            List<string> shortStrings = stringRepository.Find(criteria);

            Console.WriteLine("Short strings:");
            foreach (string item in shortStrings)
            {
                Console.WriteLine(item);
            }

            Repository<int> intRepository = new Repository<int>();
            intRepository.Add(5);
            intRepository.Add(10);
            intRepository.Add(15);
            intRepository.Add(20);

            Criteria<int> evenNumbers = i => i % 2 == 0;
            List<int> evenIntegers = intRepository.Find(evenNumbers);

            Console.WriteLine("Even numbers:");
            foreach (int item in evenIntegers)
            {
                Console.WriteLine(item);
            }
        }
    }
}