using System;
namespace Task1.StudentsAndCourses
{
    public class Student : IStudent
    {
        private string name;
        private int id;

        public Student(string name, int id)
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
                if (string.IsNullOrEmpty(value)) 
                {
                    throw new ArgumentNullException();
                }

                this.name = value;
            }
        }

        public int Id
        {
            get 
            {
                return this.id;
            }
            set 
            {
                if (value < 10000 && value > 99999) 
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.id = value;
            }
        }
    }
}
