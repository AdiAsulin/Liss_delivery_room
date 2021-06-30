using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Liss_delivery_room
{

    class Cleaner : Employee
    {
        public Department.type department;
        protected int[] degreesArray;
        public Cleaner(int id, string name, double baseSalary, double montlyHours, HashSet<int> degreesArray = null )
                        : base(id, name, baseSalary, montlyHours)
        {
            HashSet<int> cleanerDegree = new HashSet<int> { 0 };   
            if (degreesArray != null)
            {
                cleanerDegree.UnionWith(degreesArray);
            }
            this.department = (Department.type)1;
            this.degreesArray = cleanerDegree.ToArray();
        }



        private void Clean()
        {
            Console.WriteLine("I'm Cleaning");
        }

        public override double GetSalary()
        {
            return Cleaner.mergeSalaryDegree(this.degreesArray, this.baseSalary);
        }

        public override double GetFinalSalary()
        {
            return GetSalary() * this.montlyHours;
        }




    }
}

