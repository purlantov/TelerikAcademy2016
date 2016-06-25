using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.SchoolClasses
{
    public class People
    {
        //fields
        private string firstName;
        private string lastName;
        private string comment;

        public People(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        //Properties
        public string FirstName
        {
            get { return this.firstName; }
            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name can not be empty!");
                }
                else
                {
                    this.firstName = value;
                }
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name can not be empty!");
                }
                else
                {
                    this.lastName = value;
                }
            }
        }

        public string Comment
        {
            get
            {
                if (String.IsNullOrWhiteSpace(this.comment))
                {
                    return "No comment yet!";
                }
                return this.comment;
            }
            set
            {
                this.comment = value;
            }
        }
    }
}
