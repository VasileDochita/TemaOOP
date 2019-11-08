using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaOOP1._1
{
    public class Dog : Animal
    {
        public Dog(string name, int age, Gender sex)
            : base(name, age, sex)
        {
            this.Type = AnimalType.Dog;
        }

        public override string MakesSound()
        {
            return "Ham - Ham";
        }
    }
}
