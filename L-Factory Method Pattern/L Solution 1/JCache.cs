﻿using System;
using System.Collections.Generic;
using static System.Console;

namespace L_Solution_1
{
    public class JCache : ICache
    {
        private int size;
        private string policy;
        private bool isSerializable;
        private Dictionary<string, int> cache;

        public JCache(int size, string policy, bool isSerializable)
        {
            this.size = size;
            this.policy = policy;
            this.isSerializable = isSerializable;
            cache = new Dictionary<string, int>();
        }

        public int get(string key)
        {
            WriteLine("Returning value from jcache");
            return new Random().Next(100);
        }

        public void put(string key, int value)
        {
            WriteLine("inserting key-value inside jcache");
        }
    }
}