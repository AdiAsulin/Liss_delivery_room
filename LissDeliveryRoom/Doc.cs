using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Liss_delivery_room
{

    class Doc : Employee
    {
        public Department.type department;
        protected int[] degreesArray;
        public Doc(int id, string name, double baseSalary, double montlyHours, HashSet<int> degreesArray = null )
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



        private void care()
        {
            Console.WriteLine("I care a lot");
        }

        public override double GetSalary()
        {
            return Doc.mergeSalaryDegree(this.degreesArray, this.baseSalary);
        }

        public override double GetFinalSalary()
        {
            return GetSalary() * this.montlyHours;
        }




    }
}

