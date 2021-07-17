using System;
using System.Collections.Generic;
using System.Linq;
// calling Lang Integrated Query

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
	// Rtrn val of nth node of LL
    {
        if (n >= myLList.Count || myLList.Count == 0 || myLList == null || n < 0)
		// if the node doesnt exist rtrn zero, start count at zero
            return 0;
        return myLList.ElementAt(n);
		// elementAt returns element at a specfic indx in seqnc
    }
}