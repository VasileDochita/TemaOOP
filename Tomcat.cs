using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaOOP1._1
{
    public class Tomcat : Cat
    {
        public Tomcat(string name, int age)
            : base(name, age, Gender.Male)
        {
            this.Type = AnimalType.Tomcat;
        }
        public override string MakesSound()
        {
            return "whatever";
        }
    }
}
