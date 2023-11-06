public class ObjectPool<T>
{
    private readonly Queue<T> pool = new Queue<T>();
    private readonly Func<T> objectFactory;
    private readonly Action<T> objectReset;

    public ObjectPool(Func<T> objectFactory, Action<T> objectReset)
    {
        this.objectFactory = objectFactory;
        this.objectReset = objectReset;
    }

    public T GetObject()
    {
        if (pool.Count > 0)
        {
            return pool.Dequeue();
        }
        return objectFactory();
    }

    public void ReturnObject(T obj)
    {
        objectReset(obj);
        pool.Enqueue(obj);
    }
}