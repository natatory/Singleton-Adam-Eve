using System;

namespace Singleton_Adam_Eve
{
    public sealed class Eve : Female
    {
        static object locker = new object();
        private static Eve uniqueInstance;
        private Eve(string name) : base(name) { }
        public static Eve GetInstance(Adam adam)
        {
            lock (locker)
            {
                if (adam == null) throw new ArgumentNullException();
                if (uniqueInstance == null) uniqueInstance = new Eve("Eve");
                return uniqueInstance;
            }
        }
    }

}
