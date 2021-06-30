using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Liss_delivery_room
{

    class So_chef : Cook
    {
        private double risk;
        public So_chef (int id, string name, double baseSalary, double montlyHours)
                        : base(id, name, baseSalary, montlyHours,new HashSet<int> {5})
        {
       
        }


        private void cook()
        {
            Console.WriteLine("I'm Cleaning At Risk");
        }
        public override double  GetSalary()
        {
            return So_chef.mergeSalaryDegree(this.degreesArray, this.baseSalary, this.risk);
        }

        public override double GetFinalSalary()
        {
            return GetSalary() * this.montlyHours;
        }

    }
}

