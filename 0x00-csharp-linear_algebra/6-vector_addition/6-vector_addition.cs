using System;
using System.Collections.Generic;

///<summary>Adds two vectors and returns resulting vector</summary>
class VectorMath
{
    ///<summary> Prototype given </summary>
    public static double[] Add(double[] vector1, double[] vector2)
    {

        double[] ret = new double[1]{-1};
        if (vector1.Length == 2 && vector2.Length == 2)
            ret = new double[2] {(vector1[0] + vector2[0]), (vector1[1] + vector2[1])};
        if (vector1.Length == 3 && vector2.Length == 3)
            ret = new double[3] {(vector1[0] + vector2[0]), (vector1[1] + vector2[1]), (vector1[2] + vector2[2])};
        
        
        return ret;
    }
}
