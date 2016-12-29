using System;

namespace DefineClass
{
    public class Battery
    {
        //
        //  Fields
        //
        private string model="oem";
        private int? hoursIdle;
        private int? hoursTalk;

        public enum BatteryType
        {
            LiIon,
            NiMH,
            NiCd
        }

        //
        //  Constructors
        //
        public Battery()
        {
        }

        public Battery(string model, BatteryType type, int hoursIdle, int hoursTalk)
        {
            this.Model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursIdle;
        }

        //
        //  Properties
        //
        public string Model
        {
            get { return this.model; }
            set
            {
                if (string.IsNullOrEmpty(value) &&
                   this.model.Length < 2)
                {
                    throw new ArgumentException("Model name have to be at least 2 symbols!");
                }
                this.model = value;
            }
        }

        public int? HoursIdle
        {
            get { return this.hoursIdle; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Hours idle must be positive number!");
                }
                this.hoursIdle = value;
            }
        }

        public int? HoursTalk
        {
            get { return this.hoursTalk; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Hours talk must be positive number!");
                }
                this.hoursTalk = value;
            }
        }
    }
}

