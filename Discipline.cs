using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaOOP1._2
{
    public class Discipline:Comment
    {
        private string disciplineName;
        private int numberOfLectures;
        private int numberOfExercises;

        public Discipline(string disciplineName, int numberOfLectures, int numberOfExercises)
        {
            this.disciplineName = disciplineName;
            this.numberOfLectures = numberOfLectures;
            this.numberOfExercises = numberOfExercises;
        }

        public string DisciplineName
        {
            get { return this.disciplineName; }
            set
            {
                if (value == null)
                {
                    Console.WriteLine("Please enter a name of a discipline");
                }
                else
                {
                    this.disciplineName = value;
                }
            }
        }

        public int NumberOfLectures
        {
            get { return this.numberOfLectures; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Insert valid number ( > 0)"); 
                }
                else
                {
                    this.numberOfLectures = value;
                }
            }
        }

        public int NumberOfExercises
        {
            get { return this.numberOfExercises; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Insert valid number ( > 0)");
                }
                else
                {
                    this.numberOfExercises = value;
                }
            }
        }
    }
}
        
    

