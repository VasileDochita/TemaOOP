using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaOOP1._1
{
    public class Cat : Animal
    {
        public Cat(string name, int age, Gender sex)
            : base(name, age, sex)
        {
            this.Type = AnimalType.Cat;
        }

        public override string MakesSound()
        {
            return "Miau!";
        }
    }
}
