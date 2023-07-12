namespace Packt.Shape;

public abstract class Shape
{
    // Fields
    protected double height;

    protected double width;

    // Properties
    public virtual double Height
    {
        get
        {
            return height;
        }
        set
        {
            height = value;
        }
    }

    public virtual double Width
    {
        get
        {
            return width;
        }
        set
        {
            width = value;
        }
    }

    // Abtract property area
    // Must be fully implemented in the derived class
    public abstract double Area
    {
        get;
    }

}