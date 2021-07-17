using System;
using System.Collections.Generic;


class LList
// link list
{
    public static int GetNode(LinkedList<int> myLList, int n)
	// new node in corect position in ordered LL
    {
        int h = 0;
		// val set at 0
        
        foreach (int node in myLList)
		// Loop thru nodes in myList
        {
            if (h == n)
			// if val is same as the int
            {   
                return node;
            }
            h++;
        }
        return 0;
    }
}