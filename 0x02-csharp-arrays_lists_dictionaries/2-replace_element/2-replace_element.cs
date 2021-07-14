using System;


    class Array
	// write method that replaces an element of an array at a given index.
    {
        public static int[] ReplaceElement(int[] array, int index, int n)
		// return an update Array
		// If index is out of range, print Index out of range and 
		// return the unchanged array
        {
			if (index < 0 || index >= array.Length)
        {
            Console.WriteLine("Index out of range");
        }
        else
        {
            array[index] = n;
        }
        return (array);
        }
    }