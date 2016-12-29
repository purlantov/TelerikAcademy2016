using System;

namespace DefineClass
{
    public class Call
    {
        //
        //  Fields
        //
        private DateTime date;
        private string time;
        private string number;
        private int duration;

        //
        //  Constructors
        //
        public Call()
        {
        }

        public Call(DateTime date, string time, string number, int duration)
        {
            this.Date = date;
            this.Time = time;
            this.Number = number;
            this.Duration = duration;
        }

        //
        //  Properties
        //
        public DateTime Date
        {
            get { return this.date; }
            set { this.date = value; }
        }

        public string Time
        {
            get { return this.time; }
            set { this.time = value; }
        }

        public string Number
        {
            get { return this.number; }
            set { this.number = value; }
        }

        public int Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }

        //
        //  Methods
        //
        public override string ToString()
        {
            return string.Format($"[Call: Date={Date}, Time={Time}, Number={Number}, Duration={Duration} sec.]");
        }
    }
}

