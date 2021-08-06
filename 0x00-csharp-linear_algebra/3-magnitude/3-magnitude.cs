using System;
using System.Collections.Generic;

///<summary> Our Vector Class </summary>
class VectorMath
{
	///<summary> Given Prototype </summary>
    public static double Magnitude(double[] vector)
    {
        double result;
		///<summary> If 2D </summary>
        if (vector.Length == 2) {
            result = (Math.Sqrt(Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2)));
            return Math.Round(result, 2);
            }
		///<summary> If 3D </summary>	
        else if (vector.Length == 3) {
            result = (Math.Sqrt(Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2) + Math.Pow(vector[2], 2)));
            return Math.Round(result, 2);
            }
		///<summary> if not 2D or 3D </summary>	
        else
            return -1;
    }
}