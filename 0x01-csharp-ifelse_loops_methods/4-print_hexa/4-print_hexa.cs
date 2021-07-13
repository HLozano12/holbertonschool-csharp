using System;

namespace _4_print_hexa
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int hexa = 0; hexa <= 98; hexa++)
				Console.WriteLine("{0} = 0x{0:x}", hexa);
        }
    }
}
