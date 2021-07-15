using System;
using System.Collections.Generic;

    class List
    {
        public static List<int> DifferentElements(List<int> list1, List<int> list2)
        {
            HashSet<int> Set1 = new HashSet<int>(list1);
			HashSet<int> Set2 = new HashSet<int>(list2);
        	HashSet<int> NewHash = new HashSet<int>(Set1);

			NewHash.SymmetricExceptWith(Set2);
			List<int> NewList = new List<int>(NewHash);
			NewList.Sort();
			return (NewList);
        }
    }