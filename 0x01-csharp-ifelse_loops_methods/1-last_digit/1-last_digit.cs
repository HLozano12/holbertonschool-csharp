using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
		int h = number % 10;
		string statement;

		if (h > 5)
		{
			statement = "and is greater than 5";
		}
		else if (statement == 0)
		{
			statement = "and is 0";
		}
		else
		{
			statement = "and is less than 6 and not 0";
		}
		Console.WriteLine("The last digit of {0} is {1}{2}", number, h, statement);
    }
}