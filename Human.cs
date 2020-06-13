using System;

namespace Singleton_Adam_Eve
{
    public abstract class Human
    {
        public string Name { get; }
        public Female Mother { get; }
        public Male Father { get; }
        protected Human(string name)
        {
            Name = name;
        }
        protected Human(string name, Female mother, Male father)
        {
            if (mother == null || father == null) throw new ArgumentNullException();
            Name = name;
            Father = father;
            Mother = mother;
        }
    }

}
