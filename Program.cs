using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaOOP1
{
    class Program
    {
        private static void Main(string[] args)
        {
            var student1 = new Student("Andrei", "Popesco", 8);
            var student2 = new Student("vasile", "dochita", 7);
            var student3 = new Student("butnaru", "alexandra", 9);
            var student4 = new Student("butnaru", "roxana",7.5);
            var student5 = new Student("butnaru", "gabriela", 9.1);
            var student6 = new Student("butnaru", "vlad", 9.3);
            var student7 = new Student("dochita", "victor", 9.4); 
            var student8 = new Student("dochita", "alexandra", 9.5);
            var student9 = new Student("dochita", "cristi", 10);
            var student10 = new Student("hizanu", "eleonora", 10);


            var students = new List<Student> { student1, student2, student3, student4, student5, student6, student7, student8, student9, student10 };
            students = students.OrderBy(student => student.Grade).ToList();

            foreach (var student in students)
            {
                student.Print();
            }

            
            var worker1 = new Worker("Andrei", "Andreescu", 750, 8);
            var worker2 = new Worker("Paul", "Ionescu", 650, 8);
            var worker3 = new Worker("Andreea", "bumbea", 700, 8);
            var worker4 = new Worker("Radu", "Bivol", 700, 8);
            var worker5 = new Worker("Adrian", "Cocolos", 550, 8);
            var worker6 = new Worker("Munteanu", "Ovidiu", 450, 8);
            var worker7 = new Worker("iulian", "rotaru", 450, 8);
            var worker8 = new Worker("andrei", "rotaru", 520, 8);
            var worker9 = new Worker("iulia", "burduta", 510, 8);
            var worker10 = new Worker("maxim", "toader", 720, 8);


            var workers = new List<Worker> { worker1, worker2, worker3, worker4, worker5, worker6, worker7, worker8, worker9, worker10 };
            workers = workers.OrderByDescending(worker => worker.MoneyPerHour()).ToList();

            foreach (var worker in workers)
            {
                worker.Print();
            }

            

            var list = new List<Human>();

            foreach (var student in students)
            {
                list.Add(student); 
            }

            foreach (var worker in workers)
            {
                list.Add(worker); 
            }

           

            foreach (var human in list)
            {
                human.Print();
            }
            var sortare = workers.Concat(students);





            Console.ReadLine();
        }
    }
}
