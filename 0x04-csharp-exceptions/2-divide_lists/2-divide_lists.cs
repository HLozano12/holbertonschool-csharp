using System;
using System.Collections.Generic;

    class List
    {
        public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
		// divide element by element 2 lists
		// length can be bigger than the len of either list
		// return a new list with results
		// 0 is result if 2 elem not able to divide
        {
			List<int> NList = new List<int>();
			// The new list to return result

            for (int h = 0; h < listLength; h++)
			// The loop
			{
				try
				{
					NList.Add(list1[h] / list2[h]);
					// devide the lists
				}
				catch (DivideByZeroException)
				{
					Console.WriteLine("Cannot divide by zero");
					// exception if divided by zero
					NList.Add(0);
				}
				catch (ArgumentOutOfRangeException)
				// If etiher list is too short
				{
					Console.WriteLine("Out of range");
				}
			}
			return (NList);
        }

    }