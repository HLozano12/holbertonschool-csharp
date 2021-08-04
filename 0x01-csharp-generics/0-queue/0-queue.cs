using System;

///<summary>Queue class</summary>
class Queue<T>
{
    ///<summary> returns the type</summary>
    public Type CheckType()
    {
        return typeof(T);
    }
}
