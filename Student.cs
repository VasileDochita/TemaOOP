using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaOOP1
{
    public class Student:Human
    {
        public Student(string firstName, string lastName, double grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public double Grade { get; set; }

        public new void Print()
        {
            base.Print();
            Console.WriteLine($"\t Grade: {this.Grade}");
            Console.WriteLine();
        }
    }
}
