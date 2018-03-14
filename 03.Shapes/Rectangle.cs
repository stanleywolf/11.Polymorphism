using System;
using System.Collections.Generic;
using System.Text;

public class Rectangle : Shape
{
    public Rectangle(double height, double width)
    {
        this.Height = height;
        this.Width = width;
    }

    public double height;
    public double width;

    public double Height
    {
        get
        {
            return this.height;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(this.Height), "Zero or negative");
            }
            this.height = value;
        }
    }

    public double Width
    {
        get { return this.width; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(this.width), "Zero or negative");
            }
            this.width = value;
        }
    }

    public override double CalculatePerimeter()
    {
        return this.Height * this.Width;
    }

    public override double CalculateArea()
    {
        return this.Height * 4;
    }

    public override string Draw()
    {
        return base.Draw() + "Rectangle";
    }
}