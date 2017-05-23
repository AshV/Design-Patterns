// Source: csharpindepth.com/Articles/General/Singleton.aspx
// First version - not thread-safe
namespace K_JonSkeet_1
{
    // Bad code! Do not use!
    public sealed class Singleton
    {
        private static Singleton instance = null;
        private Singleton()
        {
        }
        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
    }
}