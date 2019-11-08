using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaOOP1._1
{
    public class HierarchyAnimals
    {
        //public enum Gender
        //{
        //    Male,
        //    Female,
        //}

        //public enum AnimalType
        //{
        //    Dog,
        //    Frog,
        //    Cat,
        //    Kitten,
        //    Tomcat
           
        //}
        static void Main(string[] args)
        {
            Kitten kitten = new Kitten("PisPis", 2);
            Tomcat tomcat = new Tomcat("Tommy", 3);
            Frog frog = new Frog("Prince", 6, Gender.Male);
            Dog dog = new Dog("Bully", 4, Gender.Male);
            Cat cat = new Cat("pisica", 5, Gender.Female);

            List<Animal> animals = new List<Animal>() { kitten, tomcat, frog, dog, cat };
          

            Kitten[] Pisoi = new Kitten[] { kitten, new Kitten("Pis", 2), new Kitten("Puf", 3) };
            Tomcat[] tomcats = new Tomcat[] { tomcat, new Tomcat("Paf", 3), new Tomcat("Puf", 1), new Tomcat("Paul", 2) };
            Frog[] Broaste = new Frog[] { frog, new Frog("broscuta", 12, Gender.Female), new Frog("broscoi", 1, Gender.Male) };
            Dog[] dogs = new Dog[] { dog, new Dog("Catea", 2, Gender.Female), new Dog("Caine", 10, Gender.Male) };
            Cat[] cats = new Cat[] { cat };

            Console.WriteLine("Varsta medie la Pisoi este : {0:F2}", Animal.AverageAge(Pisoi));
            Console.WriteLine("Varsta medie la Tomcat: {0:F2}", Animal.AverageAge(tomcats));
            Console.WriteLine("Varsta medie la Broaste: {0:F2}", Animal.AverageAge(Broaste));
            Console.WriteLine("Varsta medie la Caini : {0:F2}", Animal.AverageAge(dogs));
            Console.WriteLine("Varsta medie la Pisici: {0:F2}", Animal.AverageAge(cats));
            Console.ReadLine();
        }

       
    }
        
    
}
