using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaOOP1._1
{
    public class Kitten : Cat
    {
        public Kitten(string name, int age)
            : base(name, age, Gender.Female)
        {
            this.Type = AnimalType.Kitten;
        }
        public override string MakesSound()
        {
            return "Rrr";
        }
    }
}
