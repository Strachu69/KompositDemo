using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Children
{
    public interface IChildren
    {
        void Eat();
        void Sleep();

        void Add(IChildren children);
    }
}
