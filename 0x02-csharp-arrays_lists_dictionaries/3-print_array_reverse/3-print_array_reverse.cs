using System;

    class Array
    {
        public static void Reverse(int[] array)
		// print all integer of an array, in revrse
    		{
        		if (array != null)
        		{
            		for (int h = array.Length - 1; h >= 0; h--)
					// Reverse
            		{
                		Console.Write(array[h]);
                		if (h != 0)
                		{
                    		Console.Write(" ");
                		}
            		}
        		}    
        		Console.WriteLine();
        	}
    }