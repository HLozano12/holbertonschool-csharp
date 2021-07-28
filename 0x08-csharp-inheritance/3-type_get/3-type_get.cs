using System;
using System.Reflection;
using System.Collections.Generic;

/// <summary>Obj class given per proj</summary>
class Obj
{
    /// <summary>Prints the names of the properties of an obj</summary>
        public static void Print(object myObj)
    {
        TypeInfo t = myObj.GetType().GetTypeInfo();
        Console.WriteLine($"{t.Name} Properties:");
        foreach (PropertyInfo i in t.GetProperties())
        {
            Console.WriteLine(i.Name);
        }
        Console.WriteLine($"{t.Name} Methods:");
        foreach (MethodInfo x in t.GetMethods())
        {
            Console.WriteLine(x.Name);
        }
    }
}