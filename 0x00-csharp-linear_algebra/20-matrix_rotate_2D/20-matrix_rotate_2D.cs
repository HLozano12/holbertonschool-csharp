using System;

///<summary> Matrix Class </summary> 
class MatrixMath
{
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        double[,] rotateMatrix = new double[2,2];
        double[,] ErrorSize = new double[,]{{-1}};
        double[,] rotate = new double[2, 2] {{Math.Cos(angle), Math.Sin(angle)}, {-1 * Math.Sin(angle), Math.Cos(angle)}};
        int row = matrix.GetLength(0);
        int col = matrix.GetLength(1);
        

        if (row != 2 || col != 2)
        {
            return ErrorSize;
        }
        
        for (int h = 0; h < row; h++)
        {
            for(int j = 0; j < col; j++)
            {
                for (int a = 0; a < 2; a++)
                {
                    rotateMatrix[h,j] = Math.Round(rotateMatrix[h, j] + (matrix[h, a] * rotate[k, j]), 2);
                }
            }
        }

        return rotateMatrix;
    }
}