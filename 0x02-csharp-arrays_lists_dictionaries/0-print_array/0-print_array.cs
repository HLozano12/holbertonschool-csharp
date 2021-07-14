using System;

    class Array
	// Print Array of Given Size
	// blank if size is zero, "Cannot be Neg" and return Null if >0
    {
        public static int[] CreatePrint(int size)
        {
            if (size == 0)
        	{
            	Console.WriteLine();
        	}
        	if (size < 0)
        	{
            	Console.WriteLine("Size cannot be negative");
            	return (null);
        	}
        	int[] NewArray = new int[size];
        
			for (int h = 0; h < size; h++)
        	{
            	NewArray[h] = h;
            	Console.Write(NewArray[h]);
            	
				if (h == size - 1)
            	{
                	Console.WriteLine();
            	}
            	else
            	{
                	Console.Write(" ");
            	}
        	}
        	return (NewArray);
        }
    }