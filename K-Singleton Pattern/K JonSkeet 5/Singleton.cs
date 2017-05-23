// Source: csharpindepth.com/Articles/General/Singleton.aspx
// Fifth version - fully lazy instantiation
namespace K_JonSkeet_5
{
    public sealed class Singleton
    {
        private Singleton()
        {
        }
        public static Singleton Instance { get { return Nested.instance; } }
        private class Nested
        {
            // Explicit static constructor to tell C# compiler
            // not to mark type as beforefieldinit
            static Nested()
            {
            }
            internal static readonly Singleton instance = new Singleton();
        }
    }
}