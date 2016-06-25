using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SchoolClasses
{
    class Test
    {
        static void Main()
        {
            Teacher teach = new Teacher("Zlatka", "Ivanova");
            teach.AddDiscipline(new Disciplines("matematika", 1, 14)); //asign discipline to teacher
            teach.AddDiscipline(new Disciplines("Fizika", 2, 15));

            Teacher teacherIvan = new Teacher("Ivan", "Ivanov", new Disciplines("Math", 5, 14));
            teacherIvan.AddDiscipline(new Disciplines("Phisycs", 5, 15));

            Students studentIvan = new Students("Pavel","Ivanov");
            Students studentPeho = new Students("Petar", "Petrov");
            Classes class1 = new Classes(teach, studentIvan, "46153689");
            class1.AddStudent(studentPeho);

            Console.WriteLine(class1);
            Console.WriteLine("==========================================");

            Console.WriteLine(teach);
            Console.WriteLine(teacherIvan);
        }
    }
}
