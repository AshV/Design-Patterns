using System;

namespace L_Solution_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            ICacheFactory cacheFactory = new CacheFactory();
            ICache cache = cacheFactory.getCache(n);

            cache.put("abc", 100);
            cache.put("def", 2000);
            cache.put("xyz", 170);
            cache.get("abc");
        }
    }
}