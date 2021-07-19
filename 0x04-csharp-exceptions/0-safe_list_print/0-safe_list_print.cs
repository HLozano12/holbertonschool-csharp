using System;
using System.Collections.Generic;

    class List
    {
        public static int SafePrint(List<int> myList, int n)
		// print n elements of a list
		// use try / catch
		// int n is # of elements to print
        {
            int h = 0;

			foreach (int element in myList)
			try
			// Holds the suspected code w possible exceptions
			{
				if (h < n)
				{
					Console.WriteLine(element);
					h++;
				}
			}	
			catch
				// catch exception w/ exception handle
			{
				return h;	
			}
			return h;
        }
    }