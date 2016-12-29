using System;
namespace DefiningClasses_Part1
{
    public class GSM
    {
        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        private Battery battery;
        private Display display;

        public GSM(string manufacturer, string model)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
        }

        public GSM(string manufacturer, string model, decimal price,
                   string owner, Battery battery, Display display)
            : this(manufacturer, model)
        {
            this.Price = price;
            this.Owner = owner;
        }

        public string Model
        {
            get { return this.model; }
            set
            {
                if (string.IsNullOrEmpty(this.model) &&
                this.model.Length < 2)
                {
                    throw new ArgumentNullException();
                }
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (string.IsNullOrEmpty(this.manufacturer) &&
                    this.manufacturer.Length < 2)
                {
                    throw new ArgumentNullException();
                }
                this.manufacturer = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (this.price <= 0)
                {
                    throw new ArgumentException("Price have to be bigger than 0!");
                }
                this.price = value;
            }
        }

        public string Owner
        {
            get { return this.owner; }
            set
            {
                if (string.IsNullOrEmpty(this.owner) &&
                   this.owner.Length < 2)
                {
                    throw new ArgumentNullException();
                }
                this.owner = value;
            }
        }

        public Battery Battery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }

        public Display Display
        {
            get { return this.display; }
            set { this.display = value; }
        }

    }
}
