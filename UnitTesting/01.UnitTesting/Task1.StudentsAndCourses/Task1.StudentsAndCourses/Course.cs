using System;
using System.Collections.Generic;

namespace Task1.StudentsAndCourses
{
    public class Course
    {
        private ICollection<IStudent> students;
        private string name;

        public Course(string name)
        {

        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.name = value;
            }
        }

        public void Join(IStudent student)
        {
            if (students.Count < 30)
            {
                this.students.Add(student);
            }
        }

        public void Leave(IStudent student)
        {
            this.students.Remove(student);
        }


    }
}
