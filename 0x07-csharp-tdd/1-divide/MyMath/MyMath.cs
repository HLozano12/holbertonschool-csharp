using System;

namespace MyMath
{
/// <summary> Given Class </summary>
    public class Matrix
    {
		/// <summary> Given prototype for Dividing a matrix </summary>
		public static int[,] Divide(int[,] matrix, int num)
		{
			if (num == 0 || matrix == null)
			{
				if (num == 0)
					Console.WriteLine("Num cannot be 0");
				return (null);
			}
			for (int h = 0; h < matrix.GetLength(0); h++)
			{
				for (int l = 0; l < matrix.GetLength(1); l++)
				{
					matrix[h, l] = matrix[h, l] / num;
				}
			}
			return (matrix);
		}
    }
}
