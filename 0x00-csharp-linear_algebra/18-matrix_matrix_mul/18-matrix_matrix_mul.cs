using System;

///<summary> Matrix Class </summary> 
class MatrixMath
{
    ///<summary>Prototype given for multipling two matrices </summary>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        double[,] NoMul = new double[,]{{-1}};
        double[,] ProdMatrix;
        int row = matrix1.GetLength(0);
        int col = matrix1.GetLength(1);
        int row2 = matrix2.GetLength(0);
        int col2 = matrix2.GetLength(1);
    
    if (col != row2)
    {
        return NoMul;
    }

    ProdMatrix = new double [row, col2];
    for (int h = 0; h < row; h++)
    {
        for (int k = 0; k < col2; k++)
        {
            double temp = 0;

            for (int l = 0; l < col; l++)
            {
                temp += matrix1[h, l] * matrix2[l, k];
            }
            ProdMatrix[h,k] = temp;
        }
    }
    return ProdMatrix;
    }

}