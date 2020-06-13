namespace Singleton_Adam_Eve
{
    public class Female : Human
    {
        protected Female(string name) : base(name) { }
        public Female(string name, Female female, Male male) : base(name, female, male) { }
    }

}
