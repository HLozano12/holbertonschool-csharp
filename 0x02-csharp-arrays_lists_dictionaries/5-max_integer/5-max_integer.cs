using System;
using System.Collections.Generic;
    class List
	// Find the biggest integer of a list 
    {
        public static int MaxInteger(List<int> myList)
		// Return largest element in a given list
		// if list empty, print "List is empty" and return -1
		// Not allowed to use .Max()
        {
            if (myList.Count == 0 || myList == null)
        	{
            	Console.WriteLine("List is empty");
            	return (-1);
        	}
        	// .Sort() Method is used to sort the elements in the List<T>
			// GeeksforGeeks Ref
        	myList.Sort();
        	return (myList[myList.Count -1]);
        }
    }