using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Liss_delivery_room
{

    class sub_Main_Dep_doc : Employee
    {
        public Department.type department;
        protected int[] degreesArray;
        public sub_Main_Dep_doc(int id, string name, double baseSalary, double montlyHours, HashSet<int> degreesArray = null )
                        : base(id, name, baseSalary, montlyHours)
        {
            HashSet<int> cleanerDegree = new HashSet<int> { 4, 3 };   
            if (degreesArray != null)
            {
                cleanerDegree.UnionWith(degreesArray);
            }
            this.department = (Department.type)0;
            this.degreesArray = cleanerDegree.ToArray();
        }



        private void Manege()
        {
            Console.WriteLine("Im the boss");
        }

        public override double GetSalary()
        {
            return sub_Main_Dep_doc.mergeSalaryDegree(this.degreesArray, this.baseSalary);
        }

        public override double GetFinalSalary()
        {
            return GetSalary() * this.montlyHours;
        }




    }
}

