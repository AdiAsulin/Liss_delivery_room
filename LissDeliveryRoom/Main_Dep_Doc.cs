using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Liss_delivery_room
{

    class Main_Dep_Doc : Employee
    {
        public Department.type department;
        protected int[] degreesArray;
        private double risk;
        public Main_Dep_Doc(int id, string name, double baseSalary, double montlyHours, HashSet<int> degreesArray = null )
                        : base(id, name, baseSalary, montlyHours)
        {
            HashSet<int> cleanerDegree = new HashSet<int> { 4, 5 };
            this.risk = 2;
            if (degreesArray != null)
            {
                cleanerDegree.UnionWith(degreesArray);
            }
            this.department = (Department.type)0;
            this.degreesArray = cleanerDegree.ToArray();
            

        }




        private void bossing()
        {
            Console.WriteLine("Im the big boss");
        }

        public override double GetSalary()
        {
            return Main_Dep_Doc.mergeSalaryDegree(this.degreesArray, this.baseSalary);
        }

        public override double GetFinalSalary()
        {
            return GetSalary() * this.montlyHours;
        }




    }
}

