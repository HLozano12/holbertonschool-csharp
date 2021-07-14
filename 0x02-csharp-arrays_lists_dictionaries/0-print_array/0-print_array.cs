using System;

namespace _0_print_array
{
    class Array
	// Print Array of Given Size
	// blank if size is zero, "Cannot be Neg" and return Null if >0
    {
        public static int[] CreatePrint(int size)
        {
            if (size == 0)
			{
				Console.WriteLine();
			}
			if (size < 0)
			{
				Console.WriteLine("Size cannot be negative");
			}
			int[] Array = new int[size];

			for (int h = 0; h < size; h++)
			{
				Array[h] = h;
				Console.Write(Array[h]);
				if (h == size - 1)
				{
					Console.WriteLine();
				}
				else
				{
					Console.Write(" ");
				}
			}
			return (Array);	
        }
    }
}
