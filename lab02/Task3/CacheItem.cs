namespace Task3
{
    using System;

    public class CacheItem<T>
    {
        public T Value { get; }
        public DateTime CreatedTime { get; }

        public CacheItem(T value)
        {
            Value = value;
            CreatedTime = DateTime.Now;
        }

        public bool IsValid(TimeSpan duration)
        {
            return (DateTime.Now - CreatedTime) <= duration;
        }
    }
}