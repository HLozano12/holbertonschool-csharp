using System;
using System.Collections.Generic; // for error CS0308


    class List
    {
        public static List<int> CreatePrint(int size)
        // Print a list of ints of given size
		{
            // int should start w/ 0 and ++ until given size
			// return new list
			// if 0 < size print Size cannot be neg, return NULL
			if (size < 0)
        	{
            	Console.WriteLine("Size cannot be negative");
            	return null;
        	}

        	List<int> list = new List<int>();
        	for (int h = 0; h < size; h++)
        	{
            	list.Add(h);
        	}
        	foreach (int h in list)
        	{
            	Console.Write(h);
            	if (h != size - 1)
            	{
                	Console.Write(" ");
            	}
        	}
        	Console.WriteLine();
        	return list;
        }
    }