using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Children
{
    class ButterflyChildrenSet : IChildren
    {
        string _name;
        List<IChildren> childrenList = new List<IChildren>();
        public ButterflyChildrenSet(string name)
        {
            _name = name;
        }
        public void Add(IChildren children)
        {
            childrenList.Add(children);
        }


        public void Eat()
        {
            Console.WriteLine(_name + " are eating");

            foreach (var children in childrenList)
            {
                children.Eat();
            }
        }

        public void Sleep()
        {
            Console.WriteLine(_name + " are sleeping");
            foreach (var children in childrenList)
            {
                children.Sleep();
            }
        }
    }
}
