using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Liss_delivery_room
{

    class Meyaledet2 : Meyaledet
    {
        private double risk;
        public Meyaledet2(int id, string name, double baseSalary, double montlyHours)
                        : base(id, name, baseSalary, montlyHours,new HashSet<int> {2})
        {
         
        }


        private void help()
        {
            Console.WriteLine("I'help bringings baby in a diff way");
        }
        public override double  GetSalary()
        {
            return Meyaledet2.mergeSalaryDegree(this.degreesArray, this.baseSalary, this.risk);
        }

        public override double GetFinalSalary()
        {
            return GetSalary() * this.montlyHours;
        }

    }
}

