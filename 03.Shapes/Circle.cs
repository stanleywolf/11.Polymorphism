using System;
using System.Collections.Generic;
using System.Text;

public class Circle : Shape
{
    public Circle(double radius)
    {
        this.Radius = radius;
    }

    public double radius;

    public double Radius
    {
        get { return this.radius; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(this.radius), "Zero or negative");
            }
            this.radius = value;
        }
    }

    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * this.Radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * this.Radius * this.Radius;
    }

    public override string Draw()
    {
        return base.Draw() + "Circle";
    }
}