using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_Homework
{
    public class ExamException : Exception
    {
        public ExamException()
        {

        }

        public ExamException(string message) : base(message)
        {

        }

        public ExamException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}
