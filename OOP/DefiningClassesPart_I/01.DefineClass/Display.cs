using System;

namespace DefineClass
{
    public class Display
    {
        //
        //  Fields
        //
        private double displaySize;
        private int numberOfColors;

        //
        //  Constructors
        //
        public Display()
        {
        }

        public Display(double size)
        {
            this.DisplaySize = size;
        }

        public Display(double size, int colors)
        {
            this.displaySize = size;
            this.NumberOfColors = colors;
        }

        //
        //  Properties
        //
        public double DisplaySize
        {
            get { return displaySize; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Display size can not be negative!");
                }
                this.displaySize = value;
            }
        }

        public int NumberOfColors
        {
            get { return this.numberOfColors; }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Colors of display can not be 0 or less than zero!");
                }
                this.numberOfColors = value;
            }
        }
    }
}

