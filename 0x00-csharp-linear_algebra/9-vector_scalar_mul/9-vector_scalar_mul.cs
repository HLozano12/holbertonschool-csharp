using System;

///<summary>Class for Vectors.</summary>
class VectorMath
{
    ///<summary>Protype given</summary>
    public static double[] Multiply(double[] vector, double scalar)
    {
        double[] result = new double[1] {-1};

        if (vector.Length == 2)
        {
            result = new double[2] {(vector[0] * scalar), (vector[1] * scalar)};
        }
        else if (vector.Length == 3)
        {
            result = new double[3] {(vector[0] * scalar), (vector[1] * scalar), (vector[2] * scalar)};
        }
        return result;
    }
}