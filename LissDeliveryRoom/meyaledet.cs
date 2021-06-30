using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Liss_delivery_room
{

    class Meyaledet : Employee
    {
        public Department.type department;
        protected int[] degreesArray;
        public Meyaledet(int id, string name, double baseSalary, double montlyHours, HashSet<int> degreesArray = null )
                        : base(id, name, baseSalary, montlyHours)
        {
            HashSet<int> cleanerDegree = new HashSet<int> { 1 };   
            if (degreesArray != null)
            {
                cleanerDegree.UnionWith(degreesArray);
            }
            this.department = (Department.type)0;
            this.degreesArray = cleanerDegree.ToArray();
        }



        private void help()
        {
            Console.WriteLine("I help bring baybs");
        }

        public override double GetSalary()
        {
            return Meyaledet.mergeSalaryDegree(this.degreesArray, this.baseSalary);
        }

        public override double GetFinalSalary()
        {
            return GetSalary() * this.montlyHours;
        }




    }
}

