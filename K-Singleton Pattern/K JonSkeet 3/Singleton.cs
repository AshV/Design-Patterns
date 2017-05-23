// Source: csharpindepth.com/Articles/General/Singleton.aspx
// Third version - attempted thread-safety using double-check locking
namespace K_JonSkeet_3
{
    // Bad code! Do not use!
    public sealed class Singleton
    {
        private static Singleton instance = null;
        private static readonly object padlock = new object();
        Singleton()
        {
        }
        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();
                        }
                    }
                }
                return instance;
            }
        }
    }
}