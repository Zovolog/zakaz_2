namespace Task2
{
    using System.Collections.Generic;

    public class Repository<T>
    {
        private List<T> data;

        public Repository()
        {
            data = new List<T>();
        }

        public void Add(T item)
        {
            data.Add(item);
        }

        public List<T> Find(Criteria<T> criteria)
        {
            var  results = new List<T>();
            foreach (T item in data)
            {
                if (criteria(item))
                {
                    results.Add(item);
                }
            }
            return results;
        }
    }
}