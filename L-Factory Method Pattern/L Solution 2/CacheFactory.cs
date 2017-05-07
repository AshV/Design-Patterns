namespace L_Solution_2
{
    public class CacheFactory : ICacheFactory
    {
        public ICache getCache(int n)
        {
            if (n < 200)
                return new DefaultCache(n, "lru");
            if (n < 1000)
                return new JCache(n, "fifo", true);
            return new TrieCache(n, "lfu", "tst");
        }
    }
}