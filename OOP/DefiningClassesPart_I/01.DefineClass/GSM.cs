using System;

namespace DefineClass
{
	public class GSM
	{
		//
		//variables
		//
		private string model;
		private string manufacturer;
		private int price;
		private string owner;
		private Battery battery;
		private Display display;

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

		public int Price { 
			get{ return this.price; }
			set{ this.price = value; }
		}

		public string Owner { 
			get{ return this.owner; }
			set{ this.owner = value; }
		}
	}
}

