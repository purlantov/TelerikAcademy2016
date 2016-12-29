using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Size
{
    public double Width { get; private set; }
    public double Height { get; private set; }

    public Size(double width, double heigth)
    {
        this.Width = width;
        this.Height = heigth;
    }

    public static Size GetRotatedSize(Size size, double angleOfRotation)
    {
        Size rotatedSize = new Size(Math.Abs(Math.Cos(angleOfRotation)) * size.Width +
                        Math.Abs(Math.Sin(angleOfRotation)) * size.Height,
                        Math.Abs(Math.Sin(angleOfRotation)) * size.Width +
                        Math.Abs(Math.Cos(angleOfRotation)) * size.Height);

        return rotatedSize;
    }
}
