namespace Singleton_Adam_Eve
{
    public sealed class Adam : Male
    {
        static object locker = new object();
        private static Adam uniqueInstance;
        private Adam(string name) : base(name) { }
        public static Adam GetInstance()
        {
            lock (locker)
            {
                if (uniqueInstance == null) uniqueInstance = new Adam("Adam");
                return uniqueInstance;
            }
        }
    }

}
