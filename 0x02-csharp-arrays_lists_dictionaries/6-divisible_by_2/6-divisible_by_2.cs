using System;
using System.Collections.Generic;


    class List
	// Find all Multiples of 2 in a list
    {
        public static List<bool> DivisibleBy2(List<int> myList)
		// Return list with True or False depending on requirements
		// Both list should be the same size
        {
			List<bool> TheNewList = new List<bool>();
            foreach (int h in myList)
			// Looping on each element
        	{
            	if ((h % 2) == 0)
				// if diviable by 2 
            	{
                	TheNewList.Add(true);
            	}
            	else
				// if not
            	{
                	TheNewList.Add(false);
            	}
        	}
        	return TheNewList;
        }
    }