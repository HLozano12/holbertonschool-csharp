using System;
using System.Collections.Generic;
    class List
	// Return sorted list of common elements in two list
    {
        public static List<int> CommonElements(List<int> list1, List<int> list2)
        // Not able to use linq or sortedlist
		{
            List<int> NewList = list1.FindAll(element => list2.Contains(element));
			return (NewList);
        }
    }