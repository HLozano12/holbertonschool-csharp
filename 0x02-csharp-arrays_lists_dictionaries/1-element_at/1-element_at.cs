using System;

    class Array
    {
        public static int elementAt(int[] array, int index)
		// Retrieve an element from an array
		// If index is out of range, print Index out of range and return -1
        {
            if (array.Length <= index || index < 0)
			{
				Console.WriteLine("Index out of range");
				return (-1);
			}
			return (array[index]);
        }
    }