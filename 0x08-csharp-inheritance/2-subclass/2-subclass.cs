using System;

///<summary>Obj Class Given by proj</summary>
class Obj
{
    ///<summary>IsOnlyASubclass returns true or false per  baseType.</summary>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        if (derivedType.IsSubclassOf(baseType))
        {
            return (true);
        }

        else 
        {
            return (false);
        }
    }
}
