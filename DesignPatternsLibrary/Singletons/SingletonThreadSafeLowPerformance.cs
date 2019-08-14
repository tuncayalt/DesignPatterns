namespace DesignPatternsLibrary.Singletons
{
    public class SingletonThreadSafeLowPerformance
    {
        private SingletonThreadSafeLowPerformance()
        {
        }

        private static readonly object padLock = new object();

        private static SingletonThreadSafeLowPerformance instance;

        public static SingletonThreadSafeLowPerformance Instance
        {
            get
            {
                lock (padLock)
                {
                    if (instance == null)
                    {
                        instance = new SingletonThreadSafeLowPerformance();
                    }

                    return instance;
                }
            }
        }
    }
}
