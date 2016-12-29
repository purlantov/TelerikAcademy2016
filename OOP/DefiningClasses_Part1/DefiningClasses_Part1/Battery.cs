using System;
namespace DefiningClasses_Part1
{
    public class Battery
    {
        private string model;
        private uint hoursIdle;
        private uint hoursTalk;

        public Battery(string model = "OEM")
        {
            this.Model = model;
        }

        public Battery(string model, uint hoursIdle, uint hoursTalk) : this(model)
        {
            //this.Model = model;
            this.HoursIdle = hoursIdle;
            this.Hourstalk = hoursTalk;
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public uint HoursIdle
        {
            get { return this.hoursIdle; }
            set
            {
                Validator.ValidateUInt(this.hoursIdle, "Hours Idle");
                this.hoursIdle = value;
            }
        }

        public uint Hourstalk
        {
            get { return this.hoursTalk; }
            set { this.hoursTalk = value; }
        }
    }
}
