using System;

namespace _10_print_line
{
    class Line
    {
        public static void PrintLine(int length)
        {
            if (length <= 0)
			{
				Console.WriteLine();
			}
			else
			{
				for (int h = 0; h < length; h++)
				{
					Console.Write("_");
				}
				Console.WriteLine();
			}
        }
    }
}
