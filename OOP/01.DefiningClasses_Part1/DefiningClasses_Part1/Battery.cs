using System;
namespace DefiningClasses_Part1
{
    public class Battery
    {
        private string model;
        private uint hoursIdle;
        private uint hoursTalk;
        public BatteryType BatteryType {get;set;}

        public Battery(string model = "OEM")
        {
            this.Model = model;
        }

        public Battery(string model, BatteryType type):this(model)
        {
            this.BatteryType = type;
        }

        public Battery(string model, uint hoursIdle, uint hoursTalk) : this(model)
        {
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
                Validator.ValidateUInt(value, "Hours Idle");
                this.hoursIdle = value;
            }
        }

        public uint Hourstalk
        {
            get { return this.hoursTalk; }
            set { this.hoursTalk = value; }
        }

        public override string ToString()
        {
            return string.Format("[Battery: BatteryType={0}, Model={1}, HoursIdle={2}, Hourstalk={3}]", 
                                 BatteryType, Model, HoursIdle, Hourstalk);
        }
    }
}
