using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.SchoolClasses
{
    public class School : IComment
    {
        protected string comment;

        public string AddCommment
        {
            get
            {
                if (string.IsNullOrEmpty(comment))
                {
                    return "There is no comments!";
                }
                else
                {
                    return this.comment;
                }
            }
            set
            {
                this.comment = value;
            }
        }
    }
}
