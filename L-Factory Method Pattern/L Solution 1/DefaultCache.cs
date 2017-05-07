using System;
using static System.Console;
using System.Collections.Generic;

namespace L_Solution_1
{
    public class DefaultCache : ICache
    {
        private int size;
        private string policy;
        private Dictionary<string, int> cache;

        public DefaultCache(int n, string policy)
        {
            size = n;
            this.policy = policy;
            cache = new Dictionary<string, int>();
        }

        public int get(string key)
        {
            WriteLine("Returning value from default cache");
            return new Random().Next(100);
        }

        public void put(string key, int value)
        {
            WriteLine("inserting key-value inside default cache");
        }
    }
}