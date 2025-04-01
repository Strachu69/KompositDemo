using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Children
{
    class ButterflyChildren : IChildren
    {
        string _name;
        public ButterflyChildren(string name)
        {
            _name = name;
        }
        public void Add(IChildren children)
        {
            throw new NotImplementedException();
        }

        public void Eat()
        {
            Console.WriteLine(_name + " is eating");
        }

        public void Sleep()
        {
            Console.WriteLine(_name + " is sleeping");
        }
    }
}
