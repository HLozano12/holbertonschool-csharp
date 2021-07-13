using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int numb = 00; numb <= 90; numb++)
			{
				int n1 = numb / 10;
				int n2 = numb % 10;
				if (numb != 89 && n1 < n2)
					Console.Write($"{num:D2}, ");
				else if (numb == 89)
					Console.WriteLine($"{numb:D2}");
			}
        }
    }
}
