using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaOOP1
{
    public class Worker : Human
    {
        public Worker(string firstName, string lastName, int weekSalary, int workHoursPerDay)
           : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double WeekSalary { get; set; }

        public double WorkHoursPerDay { get; set; }

        public double MoneyPerHour()
        {
            return this.WeekSalary / (this.WorkHoursPerDay * 6);
        }

        public new void Print()
        {
            base.Print();

            Console.WriteLine($"\t WeekSalary: {this.WeekSalary}  WorkHoursPerDay: {this.WorkHoursPerDay}  Salary/hour: {this.MoneyPerHour():0.00}");
            Console.WriteLine();
        }
    }
}
