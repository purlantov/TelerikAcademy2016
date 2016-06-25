using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.SchoolClasses
{
    public class Students : People
    {
        //Fields
        private uint initialNumber = 1;
        private uint classNumber;

        //Constructor
        public Students(string firstName, string lastName)
            : base(firstName, lastName)
        {
            this.ClassNumber = initialNumber++;
        }

        //Properties
        public uint ClassNumber
        {
            get { return this.classNumber; }
            private set
            {
                this.classNumber = value;
            }
        }
    }
}
