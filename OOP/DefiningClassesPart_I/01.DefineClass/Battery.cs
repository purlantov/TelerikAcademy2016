﻿namespace DefineClass
{
	using System;

	public class Battery
	{
		//
		//Variables
		//
		private string model;
		private int? hoursIdle;
		private int? hoursTalk;

		public enum BatteryType
		{
			LiIon,
			NiMH,
			NiCd
		}

		//
		//Constructors
		//
		public Battery ()
		{
		}

		public Battery (string model, BatteryType type, int hoursIdle, int hoursTalk)
		{
			this.Model = model;
			this.hoursIdle = hoursIdle;
			this.hoursTalk = hoursIdle;
		}

		//
		//Properties
		//
		public string Model {
			get{ return this.model; }
			set{ this.model = value; }
		}

		public int? HoursIdle {
			get{ return this.hoursIdle; }
			set { 
				if (value < 0) {
					throw new ArgumentException ("Hours idle must be positive number!");
				}
				this.hoursIdle = value;
			}
		}

		public int? HoursTalk {
			get{ return this.hoursTalk; }
			set {
				if (value < 0) {
					throw new ArgumentException ("Hours talk must be positive number!");
				}
				this.hoursTalk = value;
			}
		}
	}
}
