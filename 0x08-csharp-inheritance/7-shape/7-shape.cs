using System;

/// <summary> Shape Base Class </summary>
class Shape {
    public virtual int Area() {
        throw new NotImplementedException("Area() is not implemented");
    }
}

/// <summary> the rectangle class </summary>
class Rectangle : Shape
{
    private int width;
    private int height;

    /// <summary> width of Rectangle </summary>
    public int Width { 
        get { return width; }

        set {
        if (value < 0) throw new ArgumentException("Width must be greater than or equal to 0");
        else width = value;}
    }
    /// <summary> height of rectangle </summary>
    public int Height {
        get { return height; }

        set {
        if (value < 0) throw new ArgumentException("Height must be greater than or equal to 0");
        else height = value;}
    }
    /// <summary> Override the Area of rectanlge </summary>
    public new int Area()
    {
        return width * height;
    }
    /// <summary> Override the public string ToString  </summary>
    public override string ToString()
    {
        return string.Format("[Rectangle] {0} / {1}", width, height);
    }
}