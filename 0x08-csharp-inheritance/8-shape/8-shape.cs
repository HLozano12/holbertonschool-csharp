using System;

/// <summary> Shape class from prior task </summary>
class Shape {
    public virtual int Area()
    {
    throw new NotImplementedException("Area() is not implemented");
    }
}

/// <summary> Rectangle class </summary>
class Rectangle : Shape
{
    private int width;
    private int height;

    /// <summary> Our width </summary>
    public int Width
    { 
        get { return width; }

        set {
        if (value < 0) throw new ArgumentException("Width must be greater than or equal to 0");
        else width = value;}
    }
    /// <summary> Our height </summary>
    public int Height
    {
        get { return height; }

        set {
        if (value < 0) throw new ArgumentException("Height must be greater than or equal to 0");
        else height = value;}
    }
    /// <summary> Override the Area </summary>
    public new int Area()
    {
        return width * height;
    }
    /// <summary> Override the string ToString  </summary>
    public override string ToString()
    {
        return string.Format("[Rectangle] {0} / {1}", width, height);
    }
}

/// <summary> the Square class </summary>
class Square : Rectangle
{
    private int size;

    /// <summary> Method for size </summary>
    public int Size
    {
    get { return size; }
    
    set
    {
    if (value < 0) throw new ArgumentException("Size must be greater than or equal to 0");
    size = value;
    Height = value;
    Width = value;
    }
    }
}