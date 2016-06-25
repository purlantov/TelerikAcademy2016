using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.SchoolClasses
{
    public class Teacher : People
    {
        //fields
        private List<Disciplines> disciplines = new List<Disciplines>();

        //Constructor
        public Teacher(string firstName, string lastName, Disciplines dicdipline)
            : base(firstName, lastName)
        {
            this.disciplines.Add(dicdipline);
        }

        public Teacher(string firstName, string lastName)
            : base(firstName, lastName)
        {

        }

        //Properties
        public string Discipline
        {
            get 
            {
                StringBuilder temp = new StringBuilder();
                foreach (var item in this.disciplines)
                {
                    temp.Append(item.Name + "; ");
                }
                return temp.ToString();
            }
        }

        public void AddDiscipline(Disciplines discipline)
        {
            this.disciplines.Add(discipline);
        }

        public override string ToString()
        {
            return string.Format("Teacher: {0} {1}; \nLead discipline: {2}\n------------------------------------", FirstName, LastName, Discipline);
        }
    }
}
