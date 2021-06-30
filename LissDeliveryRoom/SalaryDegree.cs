using System;
using System.Collections.Generic;
using System.Text;

namespace Liss_delivery_room
{
    class SalaryDegree
    {
        public enum Degree
        {
            Common_Employee = 0,
            Executive_Empolyee = 1,
            Specialist_Empolyee = 2,
            Decisions_Maker= 3 ,
            Manager = 4,
            Risk_Empolyee = 5 
        }

        public double GetSalary(int id, double salary , double risk = 1)
        {
            switch(id)
            {
                case 0:
                    return salary;
                case 1:
                    return GetSalary(0, salary) * 1.05;
                case 2:
                    return GetSalary(0, salary) * 1.30;
                case 3:
                    return GetSalary(0, salary) * 1.50;
                case 4:
                    return salary;
                case 5:
                    return risk * salary;
                default:
                    return salary;
            }
        }
    }
}
