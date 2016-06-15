namespace DefineClass
{
	using System;

	public class Display
	{
		//
		//Variables
		//
		private double displaySize;
		private int numberOfColors;

		//
		//Constructors
		//
		public Display ()
		{
		}

		public Display (double size)
		{
			this.DisplaySize = size;
		}

		//
		//Properties
		//
		public double DisplaySize { 
			get{ return displaySize; } 
			set {
				if (value < 0) {
					throw new ArgumentException ("Display size can not be negative!");
				}
				this.displaySize = value;
			} 
		}

		public int NumberOfColors {
			get{ return this.numberOfColors; }
			set{ this.numberOfColors = value; }
		}
	}
}

