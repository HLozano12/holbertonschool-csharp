using System;
using System.Collections.Generic;


///<summary>Our given Class </summary>
class Obj 
{
    ///<summary>IsOfTypeInt returns true or false</summary>
    public static bool IsOfTypeInt(object obj)
    {
		///<summary> GetType gets the type of current instance</summary>
        if (obj.GetType() == typeof(int))
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }
}
