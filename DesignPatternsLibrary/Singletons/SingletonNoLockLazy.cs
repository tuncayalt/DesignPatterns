namespace DesignPatternsLibrary.Singletons
{
    public class SingletonNoLockLazy
    {
        private SingletonNoLockLazy()
        {
        }

        public static SingletonNoLockLazy Instance
        {
            get => Nested.instance;
        }

        private class Nested
        {
            static Nested()
            {
            }

            internal static readonly SingletonNoLockLazy instance = new SingletonNoLockLazy();
        }
    }
}
