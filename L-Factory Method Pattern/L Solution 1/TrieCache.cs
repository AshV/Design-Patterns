using static System.Console;
using System.Collections.Generic;
using System;

namespace L_Solution_1
{
    public class TrieCache : ICache
    {
        private int size;
        private string policy;
        private string type;
        private Dictionary<string, int> cache;

        public TrieCache(int size, string policy, string type)
        {
            this.size = size;
            this.policy = policy;
            this.type = type;
            cache = new Dictionary<string, int>();
        }

        public int get(string key)
        {
            WriteLine("Returning value from trie cache");
            return new Random().Next(100);
        }

        public void put(string key, int value)
        {
            WriteLine("inserting key-value inside trie cache");
        }
    }
}