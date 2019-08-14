namespace DesignPatternsLibrary.Singletons
{
    public class SingletonDoubleCheckLock
    {
        private SingletonDoubleCheckLock()
        {
        }

        private static readonly object padLock = new object();
        private static SingletonDoubleCheckLock instance;

        public static SingletonDoubleCheckLock Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padLock)
                    {
                        if (instance == null)
                        {
                            instance = new SingletonDoubleCheckLock();
                        }
                    }
                }

                return instance;
            }
        }

    }
}
