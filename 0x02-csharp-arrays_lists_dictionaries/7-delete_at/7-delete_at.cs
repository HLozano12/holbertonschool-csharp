using System;
using System.Collections.Generic;

    class List
	// Write a method that deletes the item 
	// at a specific position in a list
    {
        public static List<int> DeleteAt(List<int> myList, int index)
		// return Updated List
		// If index is out of range, print Index is out of range
		// and return the unchanged list
		// Cannot use RemoveAt
        {
            if (index < 0 || index >= myList.Count)
			// If negative or less thean
			{
				Console.WriteLine("Index is out of range");
			}
			else
			{
				myList.RemoveRange(index, 1);
				// removes a range of elements from ArrayList
			}
			return (myList);
        }
    }