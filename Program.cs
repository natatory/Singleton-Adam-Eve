using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Adam_Eve
{
    class Program
    {
        static void Main(string[] args)
        {
            Adam adam = Adam.GetInstance();
            Eve eve = Eve.GetInstance(adam);
            Console.WriteLine(adam.Name);
            Console.WriteLine(eve.Name);
            Console.ReadLine();
        }
    }

}
