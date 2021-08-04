using System;

/// <summary> abstract class  </summary>
public abstract class Base
{
    /// <summary> Public Property </summary>
    public string name;

    /// <summary> ToString override </summary>
    public override string ToString()
    {
        return String.Format("{0} is a {1}", name, this.GetType().Name);
    }
}