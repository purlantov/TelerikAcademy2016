using System;

namespace Exceptions_Homework
{
    public class ExamResult
    {
        public int Grade { get; private set; }
        public int MinGrade { get; private set; }
        public int MaxGrade { get; private set; }
        public string Comments { get; private set; }

        public ExamResult(int grade, int minGrade, int maxGrade, string comments)
        {
            if (grade < 0)
            {
                throw new ExamException("Grade must be positive!", new Exception());
            }
            if (minGrade < 0)
            {
                throw new ExamException("MinGrade must be positive!");
            }
            if (maxGrade <= minGrade)
            {
                throw new ExamException("MaxGrade must be grater than MinGrade!");
            }
            if (comments == null || comments == "")
            {
                throw new ExamException("Comments are matandory!");
            }

            this.Grade = grade;
            this.MinGrade = minGrade;
            this.MaxGrade = maxGrade;
            this.Comments = comments;
        }
    }
}