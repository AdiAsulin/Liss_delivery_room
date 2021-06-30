using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Liss_delivery_room
{

    class doc_Meyaledet : Doc
    {
        private double risk;
        public doc_Meyaledet(int id, string name, double baseSalary, double montlyHours)
                        : base(id, name, baseSalary, montlyHours,new HashSet<int> {2})
        {
            
        }


        private void care()
        {
            Console.WriteLine("I help curing");
        }
        public override double  GetSalary()
        {
            return doc_Meyaledet.mergeSalaryDegree(this.degreesArray, this.baseSalary, this.risk);
        }

        public override double GetFinalSalary()
        {
            return GetSalary() * this.montlyHours;
        }

    }
}

