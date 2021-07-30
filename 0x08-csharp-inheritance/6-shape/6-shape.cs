using System;

/// <summary> Our given Base Class </summary>
class Shape
{
    /// <summary> Our area of the shape </summary>
    public virtual int Area()
    {
    throw new NotImplementedException("Area() is not implemented");
    }
}

/// <summary> Rectangle class, WxH </summary>
class Rectangle : Shape
{
    private int width;
    private int height;

    /// <summary> Obtains the width, positive ints </summary>
    public int Width { 
        get { return width; }

        set {
        if (value < 0) {throw new ArgumentException("Width must be greater than or equal to 0");}
        width = value;}
    }
    /// <summary> Obtains Height </summary>
    public int Height {
        get { return height; }

        set
        {
        if (value < 0) {throw new ArgumentException("Height must be greater than or equal to 0");}
        height = value;}
    }
}