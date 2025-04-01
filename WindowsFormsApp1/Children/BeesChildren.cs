using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WindowsFormsApp1.Children
{
    public class BeesChildren : IChildren
    {
        string _name;
        public BeesChildren(string name)
        {
            _name = name;
        }
        public void Add(IChildren children)
        {
            throw new NotImplementedException();
        }

        public void Eat()
        {
            Console.WriteLine(_name + "Bee is eating");
        }

        public void Sleep()
        {
            Console.WriteLine(_name + " is sleeping");
        }
    }
}
