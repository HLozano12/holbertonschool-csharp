using System;
using System.Collections.Generic;

class LList
{
    public static int Length(LinkedList<int> myLList)
	// Our Prototype
	// return elements in a linked list
    {
        int count = 0;

        foreach (int item in myLList)
		// loop
        {
            count += 1;
        }
        return (count);
    }
}