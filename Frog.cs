using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaOOP1._1
{
    public class Frog : Animal
    {
        public Frog(string name, int age, Gender sex)
            : base(name, age, sex)
        {
            this.Type = AnimalType.Frog;
        }

        public override string MakesSound()
        {
            return "Ribbit";
        }
    }
}
