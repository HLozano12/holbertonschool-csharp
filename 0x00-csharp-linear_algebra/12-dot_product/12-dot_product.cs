using System;

///<summary>Class of Vectors</summary>
class VectorMath
{
    ///<summary>Given Prototype</summary>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        double result = -1;
        if ((vector1.Length == 2 || vector1.Length == 3) && vector1.Length == vector2.Length) 
        {
            result = 0;
            for (int i = 0; i < vector1.Length; i++)
            {
                result += vector1[i] * vector2[i];
            }
        }
        return result;
    }
}