using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
        int h = (number % 10);
        if (h > 5)
            Console.WriteLine($"The last digit of {number} is {h} and is greater than 5");
        else if (h == 0)
            Console.WriteLine($"The last digit of {number} is {h} and is 0");
        else
            Console.WriteLine($"The last digit of {number} is {h} and is less than 6 and not 0");
    }
}