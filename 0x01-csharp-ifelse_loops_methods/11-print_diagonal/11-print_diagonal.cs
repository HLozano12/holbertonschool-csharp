using System;

namespace _11_print_diagonal
{
    class Line
    {
        public static void PrintDiagonal(int length)
        {
            for (int h = 0; h < length; h++)
			{
				for (int a = 0; a < h; a++)
					Console.Write(" ");
				Console.WriteLine("\\");
			}
			Console.Write("\n");
        }
    }
}
