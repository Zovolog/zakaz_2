namespace Task4
{
    public class Program
    {
        static void Main(string[] args)
        {
            TaskScheduler<string, int> taskScheduler = new TaskScheduler<string, int>(task => task.Length);

            Console.WriteLine("Введіть завдання (або натисніть ENTER - щоб продовжити):");
            List<string> tasks = new List<string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                tasks.Add(input);
            }

            foreach (var task in tasks)
            {
                taskScheduler.AddTask(task);
            }

            Console.WriteLine("Початок виконання завдань з пріоритетом:");
            while (true)
            {
                taskScheduler.ExecuteNext(task => Console.WriteLine($"Виконання завдання: {task}"));
                Thread.Sleep(1000);
            }
        }
    }
}
