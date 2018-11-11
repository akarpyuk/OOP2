using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    abstract class Manufacture:Object
    {
        public string WorkshopName { get; set; }
        public string WorkshopChief { get; set; }
        public int WorkerAmount { get; set; }

        //Abstract method, without implementation
        public abstract void Some();

        //Virtual
        public virtual void GetWorkshop()
        {
            Console.WriteLine($"Workshop: { WorkshopName }, Chief: {WorkshopChief} ");
        }

        protected Manufacture( string WorkshopName, string WorkshopChief, int Workermount)
        {
            this.WorkshopName = WorkshopName;
            this.WorkshopChief = WorkshopChief;
            this.WorkerAmount = WorkerAmount;
        }
  
    }
}
