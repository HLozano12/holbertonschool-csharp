using System;
using System.Collections.Generic;
    class Int
    {
        public static void divide(int a, int b)
		// divide 2 ints and print result
		// use try/catch/finally
		// quotation should print in finally format
        {
            int result = 0;
			try
			{
				result = a / b;
				// devide the ints
			}
			catch (DivideByZeroException)
			// if exception block will handle
			// if int or decimal dividied by zero
			{
				Console.WriteLine("Cannot divide by zero");
			}
			finally
			// executes whether try block terms norm or terms due to exception
			{
				Console.WriteLine("{0} / {1} = {2}", a, b, result);
			}
        }
	}