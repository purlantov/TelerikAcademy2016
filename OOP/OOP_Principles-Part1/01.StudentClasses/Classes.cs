using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.SchoolClasses
{
    public class Classes : School
    {
        //Fields
        private string identifier;
        private const int classCapacity = 30;
        private List<Students> studentList = new List<Students>(classCapacity);
        private Teacher teacher;

        //Proprty
        public string Identifier
        {
            get { return this.identifier; }
            private set
            {
                this.identifier = value;
            }
        }

        //Constructor
        public Classes(Teacher teacher, Students student, string identifier)
        {
            this.Identifier = identifier;
            this.studentList.Add(student);
            this.teacher = teacher;
        }

        public string StudentListNames
        {
            get
            {
                StringBuilder temp = new StringBuilder();
                foreach (var item in studentList)
                {
                    temp.Append(item.FirstName + " " + item.LastName + "\n");

                }
                return temp.ToString();
            }
        }

        public void AddStudent(Students student)
        {
            studentList.Add(student);
        }

        public override string ToString()
        {
            return string.Format("Class #{0} \nTeacher:{1} \n{2}",Identifier,teacher.LastName,StudentListNames);
        }
    }
}
