namespace Singleton_Adam_Eve
{
    public class Male : Human
    {
        protected Male(string name)
            : base(name) { }
        public Male(string name, Female female, Male male)
            : base(name, female, male) { }
    }
}
