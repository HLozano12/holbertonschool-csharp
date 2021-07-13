using System;

namespace _8_print_last_digit
{
    class number
    {
        public static int PrintLastDigit(int number)
        {
            return Math.Abs(number % 10);
        }
    }
}
