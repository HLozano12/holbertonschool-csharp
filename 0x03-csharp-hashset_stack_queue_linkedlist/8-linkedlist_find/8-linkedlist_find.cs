using System;
using System.Collections.Generic;

class LList
// link list
{
    public static int FindNode(LinkedList<int> myLList, int value)
	// return indx pos of first occr of value gvn or -1
	// if val not in list
    {
        int index = -1;
		// if no given value

        foreach (int Mynode in myLList)
        {
            index += 1;
            if (Mynode == value)
            {
                break;
            }
            else if (index == myLList.Count - 1)
            {
                return -1;
            }
        }
        return index;
    }
}
