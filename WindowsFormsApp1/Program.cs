using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Children;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IChildren bee1 = new BeesChildren("Bee1");
            IChildren bee2 = new BeesChildren("Bee2");
            IChildren bee3 = new BeesChildren("Bee3");
            IChildren bees = new BeesChildrenSet("Bees");
            bees.Add(bee1);
            bees.Add(bee2);
            bees.Add(bee3);


            IChildren butterfly1 = new ButterflyChildren("Butterfly1");
            IChildren butterfly2 = new ButterflyChildren("Butterfly2");
            IChildren butterfly3 = new ButterflyChildren("Butterfly3");
            IChildren beebutterflys = new ButterflyChildrenSet("Butterflys");
            beebutterflys.Add(butterfly1);
            beebutterflys.Add(butterfly2);
            beebutterflys.Add(butterfly3);

            IChildren kindergarden = new KindergardenChilden("KinderGarden");
            kindergarden.Add(bees);
            kindergarden.Add(beebutterflys);

            kindergarden.Eat();
            kindergarden.Sleep();

        }
    }
}
