using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Workshop : Manufacture
    {
        public Workshop(string WorkshopName, string WorkshopChief, int WorkshopAmount)
            : base (WorkshopName, WorkshopChief, WorkshopAmount)
        {

        }

        public override void Some()
        {
            Product production = new Product();
        }

    }
}
