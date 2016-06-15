namespace DefineClass
{
	using System;

	public class GSM
	{
		//
		//Fields
		//
		private string model;
		private string manufacturer;
		private decimal price;
		private string owner;
		private Battery battery;
		private Display display;
		private static readonly GSM IPhone4S = new GSM ("4S", "Apple", 500, "Ivan", new Display (4), new Battery (null, Battery.BatteryType.LiIon, 168, 48));

		//
		//Constructors
		//
		public GSM (string gsmModel, string gsmManufacturer)
		{
			this.Model = gsmModel;
			this.Manufacturer = gsmManufacturer;
		}

		public GSM (string model, string manufacturer, int price, string owner) : this (model, manufacturer)
		{
			this.Price = price;
			this.Owner = owner;
		}

		public GSM (string model, string manufacturer, int price, string owner, Display display, Battery battery)
			: this (model, manufacturer, price, owner)
		{
			//TODO
		}

		//
		//Properties
		//
		public string Model { 
			get{ return this.model; }
			set{ this.model = value; } 
		}

		public string Manufacturer { 
			get{ return this.manufacturer; } 
			set{ this.manufacturer = value; }
		}

		public decimal Price { 
			get{ return this.price; }
			set {
				if (value < 0) {
					Console.WriteLine ("Enter positive value for the price!");
				} else {
					this.price = value;
				}
			}
		}

		public string Owner { 
			get{ return this.owner; }
			set{ this.owner = value; }
		}

		//
		//Methods
		//
		public override string ToString ()
		{
			return string.Format ("[GSM: Model={0}, Manufacturer={1}, Price={2}, Owner={3}]", Model, Manufacturer, Price, Owner);
		}
	}
}

