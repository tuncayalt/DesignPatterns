namespace DesignPatternsLibrary.Singletons
{
    public class SingletonNotThreadSafe
    {
        private SingletonNotThreadSafe()
        {
        }

        private static SingletonNotThreadSafe instance;

        public static SingletonNotThreadSafe Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SingletonNotThreadSafe();
                }

                return instance;
            }
        }
    }
}
