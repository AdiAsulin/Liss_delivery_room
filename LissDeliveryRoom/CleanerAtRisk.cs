using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Liss_delivery_room
{

    class CleanerAtRisk : Cleaner
    {
        private double risk;
        public CleanerAtRisk(int id, string name, double baseSalary, double montlyHours)
                        : base(id, name, baseSalary, montlyHours,new HashSet<int> {5})
        {
            this.risk = 1.2;
        }


        private void Clean()
        {
            Console.WriteLine("I'm Cleaning At Risk");
        }
        public override double  GetSalary()
        {
            return CleanerAtRisk.mergeSalaryDegree(this.degreesArray, this.baseSalary, this.risk);
        }

        public override double GetFinalSalary()
        {
            return GetSalary() * this.montlyHours;
        }

    }
}

