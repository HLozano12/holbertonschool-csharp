using System;
using System.Collections.Generic;

class LList
//Link List
{
    public static int Pop(LinkedList<int> myLList)
	// Delete the head node of LL and rtrn node data
    {
        if (myLList.Count == 0)
		// if list is empty return zero
        {
            return (0);
        }
        int nValue = myLList.First.Value;
        myLList.RemoveFirst();
		// func removes node at start
        return (nValue);
		// return value of node
    }
}