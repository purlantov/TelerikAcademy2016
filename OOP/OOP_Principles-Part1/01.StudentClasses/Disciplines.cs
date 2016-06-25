using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.SchoolClasses
{
    public class Disciplines : School
    {
        //Fields
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;

        //Constructor
        public Disciplines(string name, int lectureNumber, int exerciesNumber)
        {
            this.Name = name;
            this.NumberOfLectures = lectureNumber;
            this.NumberOfExercises = exerciesNumber;
        }

        //Properties
        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public int NumberOfLectures
        {
            get { return this.numberOfLectures; }
            set
            {
                IsInRange(value,this.numberOfLectures);
            }
        }
        public int NumberOfExercises
        {
            get { return this.numberOfExercises; }
            set 
            {
                IsInRange(value, this.numberOfExercises);
            }
        }


        private void IsInRange(int value, int input)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Number can not be negative!!!");
            }
            else
            {
                input = value;
            }
        }

        public override string ToString()
        {
            return string.Format(this.Name);
        }
    }
}
