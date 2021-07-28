using System;

///<summary> return true if the obj is an instance of or if the obj</summary>
class Obj
{
    ///<summary>Returns true if an instance of class</summary>
    public static bool IsInstanceOfArray(object obj)
    {
        return (obj is Array);
    }
}