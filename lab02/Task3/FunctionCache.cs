namespace Task3
{
    using System;
    using System.Collections.Generic;

    public class FunctionCache<TKey, TResult>
    {
        private Dictionary<TKey, CacheItem<TResult>> cache = new Dictionary<TKey, CacheItem<TResult>>();

        public delegate TResult Func<TKey, TResult>(TKey key);

        public TResult GetOrAdd(TKey key, Func<TKey, TResult> function, TimeSpan cacheDuration)
        {
            if (cache.TryGetValue(key, out CacheItem<TResult> cacheItem) && cacheItem.IsValid(cacheDuration))
            {
                return cacheItem.Value;
            }
            else
            {
                TResult result = function(key);
                cache[key] = new CacheItem<TResult>(result);
                return result;
            }
        }
    }
}