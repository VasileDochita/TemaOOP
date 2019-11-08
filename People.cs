using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaOOP1._2
{
    public abstract class Person
    {
        public Person(string Name)
        {
            
            this.Name = Name;
        }

        

        public string Name { get; set; }

        public void Print()
        {
            Console.WriteLine($"Human: {this.Name}");
        }
    }
}
