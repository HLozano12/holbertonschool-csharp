using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            for  (int numb = 00; numb <= 99; numb++)
			{
				if (numb == 99)
					Console.Write($"{numb}\n");
				else
					Console.Write($"{numb / 10}{numb % 10}, ");
			}
        }
    }
}
