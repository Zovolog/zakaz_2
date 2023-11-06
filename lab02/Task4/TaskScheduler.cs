public class TaskScheduler<TTask, TPriority>
{
    private SortedDictionary<TPriority, Queue<TTask>> taskQueue = new SortedDictionary<TPriority, Queue<TTask>>();
    private Func<TTask, TPriority> prioritySelector;

    public TaskScheduler(Func<TTask, TPriority> prioritySelector)
    {
        this.prioritySelector = prioritySelector;
    }

    public delegate void TaskExecution(TTask task);

    public void AddTask(TTask task)
    {
        TPriority priority = prioritySelector(task);
        if (!taskQueue.ContainsKey(priority))
        {
            taskQueue[priority] = new Queue<TTask>();
        }
        taskQueue[priority].Enqueue(task);
    }

    public void ExecuteNext(TaskExecution executionDelegate)
    {
        if (taskQueue.Count > 0)
        {
            TPriority highestPriority = taskQueue.Keys.Last();
            Queue<TTask> highestPriorityQueue = taskQueue[highestPriority];
            TTask taskToExecute = highestPriorityQueue.Dequeue();
            if (highestPriorityQueue.Count == 0)
            {
                taskQueue.Remove(highestPriority);
            }
            executionDelegate(taskToExecute);
        }
        else
        {
            Console.WriteLine("Немає завдань в черзі.");
        }
    }
}
