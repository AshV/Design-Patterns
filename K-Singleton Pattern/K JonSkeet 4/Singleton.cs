// Source: csharpindepth.com/Articles/General/Singleton.aspx
// Fourth version - not quite as lazy, but thread-safe without using locks
namespace K_JonSkeet_4
{
    public sealed class Singleton
    {
        private static readonly Singleton instance = new Singleton();
        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static Singleton()
        {
        }
        private Singleton()
        {
        }
        public static Singleton Instance
        {
            get
            {
                return instance;
            }
        }
    }
}