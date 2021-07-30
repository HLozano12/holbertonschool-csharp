using System;

///<summary>Our given Shape class</summary>
class Shape
{
    ///<summary>Throws NotImplementedException with message "Area() is not implemented"</summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}