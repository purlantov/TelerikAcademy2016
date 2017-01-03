using System;
namespace DefiningClasses_Part1
{
    public class Display
    {
        private float size;
        private uint colors;

        public Display()
        {
        }

        public Display(float size, uint colors)
        {
            this.Size = size;
            this.Colors = colors;
        }

        public float Size
        {
            get { return this.size;}
            set { this.size = value;}
        }

        public uint Colors
        {
            get { return this.colors;}
            set { this.colors = value;}
        }

        public override string ToString()
        {
            return string.Format("[Display: Size={0}, Colors={1}]", Size, Colors);
        }
    }
}
