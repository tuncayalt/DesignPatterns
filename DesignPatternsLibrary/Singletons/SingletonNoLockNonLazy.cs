namespace DesignPatternsLibrary.Singletons
{
    public class SingletonNoLockNonLazy
    {
        private SingletonNoLockNonLazy()
        {
        }

        static SingletonNoLockNonLazy()
        {
        }

        private static readonly SingletonNoLockNonLazy instance = new SingletonNoLockNonLazy();

        public static SingletonNoLockNonLazy Instance
        {
            get => instance;
        }
    }
}
