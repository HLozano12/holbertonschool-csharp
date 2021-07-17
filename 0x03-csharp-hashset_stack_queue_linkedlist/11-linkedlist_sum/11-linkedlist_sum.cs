using System;
using System.Collections.Generic;

class LList
// LinkList
{
    public static int Sum(LinkedList<int> myLList)
	// Rtrn the sum of all data in LnkLst
    {
        int sum = 0;
		// sum set to zero

        foreach (int indx in myLList)
		// Loop through items in LL
        {
            sum += indx;
        }
        return (sum);
		// rtrn data of all indx of LL added up
     }
}