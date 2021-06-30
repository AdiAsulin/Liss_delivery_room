using System;

namespace Liss_delivery_room
{
    class Program
    {
        static void Main(string[] args)
        {
            var Emploees = new Employee[3];
            Emploees.SetValue(new Cleaner(100, "Arbel", 50, 150), 0);
            Emploees.SetValue(new Main_ahot(101, "ADI", 50, 110), 1);
            Emploees.SetValue(new Dis_food(102, "Almog", 50, 110), 2);

            SumHours(Emploees);
            EnterEmploee(Emploees);


        }
        public static void SumHours(Employee[] Emploees)
        {
            for (int i = 0; i < Emploees.Length; i++)
            {
                Console.WriteLine("Enter the day number");
                var Dateoftheday = int.Parse(Console.ReadLine()); // Date 
                Console.WriteLine("Enter time arrival for " + Emploees[i].name);
                var startHourInput = int.Parse(Console.ReadLine()); // hour 

                Console.WriteLine("Enter leaving time for " + Emploees[i].name);
                var endHourInput = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter time arrival for " + Emploees[i].name);

                var startDate = new DateTime(2021, 6, Dateoftheday, startHourInput, 0, 0);
                var endDate = new DateTime(2021, 6, Dateoftheday, endHourInput, 0, 0);
                Emploees[i].AddTimeStamp(startDate, endDate);
                Console.WriteLine("Emp : {0} , Has A Final Wage Of : {1} , Final Salary : {2}", Emploees[i].name, Emploees[i].GetSalary(), Emploees[i].GetFinalSalary());
            }


        }
        public static void EnterEmploee(Employee[] Emploees)
        {
            for (int i = 0; i < Emploees.Length; i++)
            {
                Console.WriteLine("choose an emploee");
                string emploeename = (Console.ReadLine());
                for (int j = 0; j < Emploees.Length; j++)
                {

                    if (emploeename == Emploees[i].name)
                    {
                        Console.WriteLine("Emp : {0} , Has A Final Wage Of : {1} , Final Salary : {2}", Emploees[i].name, Emploees[i].GetSalary(), Emploees[i].GetFinalSalary());
                    }
                }
            }
        }
    }
    
}
