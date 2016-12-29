using System;
using System.Collections.Generic;

namespace DefineClass
{
    public class GSM
    {
        //
        //  Fields
        //
        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        private Battery battery;
        private Display display;
        public static readonly GSM IPhone4S =
            new GSM("iPhone 4S", "Apple", 500, "Ivan", new Display(4),
                    new Battery("OEM", Battery.BatteryType.LiIon, 168, 48));
        private List<Call> callHistory = new List<Call>();
        private const double costPerMinute = 0.30;

        //
        //  Constructors
        //
        public GSM(string gsmModel, string gsmManufacturer)
        {
            this.Model = gsmModel;
            this.Manufacturer = gsmManufacturer;
        }

        public GSM(string model, string manufacturer, int price, string owner) : this(model, manufacturer)
        {
            this.Price = price;
            this.Owner = owner;
        }

        public GSM(string model, string manufacturer, int price, string owner, Display display, Battery battery)
            : this(model, manufacturer, price, owner)
        {
            this.battery = battery;
            this.display = display;
        }

        //
        //  Properties
        //
        public string Model
        {
            get { return this.model; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Gsm Model is null or empty!!!");
                }
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("GSM Manufacturer is empty!!!");
                }
                this.manufacturer = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Enter positive value for the price!");
                }
                else
                {
                    this.price = value;
                }
            }
        }

        public string Owner
        {
            get { return this.owner; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Owner is empty!!!");
                }
                this.owner = value; 
            }
        }

        //public Battery Battery
        //{
        //    get { return this.battery; }
        //    set { this.battery = value; }
        //}

        public Display Display
        {
            get { return this.display; }
            set { this.display = value; }
        }

        public List<Call> CallHistory
        {
            get { return this.callHistory; }
        }

        //
        //  Methods
        //
        public override string ToString()
        {
            return string.Format(
                $"[GSM: Model={Model}, Manufacturer={Manufacturer}, Price={Price}, Owner={Owner}]"
            );
        }

        public void AddCall(Call call)
        {
            CallHistory.Add(call);
        }

        public void DeleteCall(int index)
        {
            CallHistory.RemoveAt(index);
        }

        public void RemoveAllCalls()
        {
            for (int i = 0; i < CallHistory.Count; i++)
            {
                DeleteCall(i);
            }
        }

        public void RemoveLongestCall()
        {
            int duration = 0;
            int index = 0;
            for (int i = 0; i < CallHistory.Count; i++)
            {
                if (CallHistory[i].Duration > duration)
                {
                    duration = CallHistory[i].Duration;
                    index = i;
                }
            }
            DeleteCall(index);
        }

        public double CallPrice(List<Call> callHistory)
        {
            double cost = 0;

            foreach (var call in callHistory)
            {
                cost += call.Duration * costPerMinute;
            }

            return cost;
        }
    }
}

