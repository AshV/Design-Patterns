// Source: csharpindepth.com/Articles/General/Singleton.aspx
// Sixth version - using .NET 4's Lazy<T> type
using System;
namespace K_JonSkeet_6
{
    public sealed class Singleton
    {
        private static readonly Lazy<Singleton> lazy =
            new Lazy<Singleton>(() => new Singleton());
        public static Singleton Instance { get { return lazy.Value; } }
        private Singleton()
        {
        }
    }
}