using System;
using System.Collections.Generic;
using System.Linq;

namespace TemaOOP1._1
{
    public abstract class Animal : ISound
    {
        public AnimalType Type { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }

        public Gender Sex { get; set; }

        public Animal(string name, int age, Gender sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
           
        }

        public virtual string MakesSound()
        {
            return "Ssss";
        }
        public static double AverageAge(IEnumerable<Animal> animals)
        {
            return animals.Average(x => x.Age);
        }



    }
}
