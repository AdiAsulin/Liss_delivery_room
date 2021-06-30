using System;
using System.Collections.Generic;
using System.Text;

namespace Liss_delivery_room
{
    abstract class Employee
    {
        private int id;
        public string name;
        public double montlyHours;
        public double baseSalary;
        public double finalSalary;

        /*public int Id { get; }
        public string Name{ get; }
        public double MontlyHours { get; set; }*/

        public Employee(int id , string name , double baseSalary, double montlyHours = 0, double finalSalary = 0)
        {
            this.id = id;
            this.name = name;
            this.baseSalary = baseSalary;
            this.montlyHours = montlyHours;
            this.finalSalary = finalSalary;
        }


        public void AddTimeStamp(DateTime startTime, DateTime endTime)
        {
            int this_month = new DateTime().Month;
            int this_year = new DateTime().Year;
            if (startTime.Year == this_year && startTime.Month == this_month)
            {
                this.montlyHours = this.montlyHours + (endTime.Subtract(startTime).TotalHours);
            }
            
        }


        static public double mergeSalaryDegree(int[] degreesArray, double wage, double risk = 1)
        {
            double FinalWage = 0;
            var wage_degree = new SalaryDegree();
            for (int i = 0; i < degreesArray.Length; i++)
            {
                FinalWage = wage_degree.GetSalary(degreesArray[i], wage, risk) - wage;
            }
            return FinalWage + wage;
        }
        public abstract double GetSalary();
        public abstract double GetFinalSalary();

        /*static public double GetSalary(int[] degreesArray, double baseSalary ,double risk)
        {
            return CleanerAtRisk.mergeSalaryDegree(degreesArray, baseSalary, risk);
        }

        static public double GetFinalSalary(double finalSalary , double montlyHours)
        {
            return finalSalary * montlyHours;
        }

        /*static public double GetWage(int id, double wage)
        {

            switch (id)
            {
                case 0:
                case 1:
                case 2:
                    return mergeWageDegree(new int[] { 0 }, wage);
                case 3:
                    return mergeWageDegree(new int[] { 1, 3 }, wage);
                case 4:
                    return mergeWageDegree(new int[] { 1 }, wage);
                case 5:
                    return mergeWageDegree(new int[] { 0, 2 }, wage);
                case 6:
                case 7:
                    return mergeWageDegree(new int[] { 0 }, wage);
                case 8:
                case 9:
                    return mergeWageDegree(new int[] { 2 }, wage);
                case 10:
                    return mergeWageDegree(new int[] { 1 }, wage);
                case 11:
                    return mergeWageDegree(new int[] { 1, 3 }, wage);
                case 12:
                    return mergeWageDegree(new int[] { 2, 1 }, wage);
                case 13:
                    return mergeWageDegree(new int[] { 4, 3 }, wage);
                case 14:
                    return mergeWageDegree(new int[] { 4, 5 }, wage, 2);
                case 15:
                    return mergeWageDegree(new int[] { 0, 3 }, wage);
                default:
                    return 0;

            }
        }*/




    }
}
