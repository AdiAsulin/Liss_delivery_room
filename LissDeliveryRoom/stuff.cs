using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Liss_delivery_room
{

    class Stuff : Employee
    {
        public Department.type department;
        protected int[] degreesArray;
        public Stuff (int id, string name, double baseSalary, double montlyHours, HashSet<int> degreesArray = null )
                        : base(id, name, baseSalary, montlyHours)
        {
            HashSet<int> cleanerDegree = new HashSet<int> { 0 };   
            if (degreesArray != null)
            {
                cleanerDegree.UnionWith(degreesArray);
            }
            this.department = (Department.type)0;
            this.degreesArray = cleanerDegree.ToArray();
        }



        private void Care()
        {
            Console.WriteLine("I care about pepole");
        }

        public override double GetSalary()
        {
            return Stuff.mergeSalaryDegree(this.degreesArray, this.baseSalary);
        }

        public override double GetFinalSalary()
        {
            return GetSalary() * this.montlyHours;
        }




    }
}

