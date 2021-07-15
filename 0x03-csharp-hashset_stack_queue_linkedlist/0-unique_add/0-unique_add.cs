using System;
using System.Collections.Generic;
    class List
    {
        public static int Sum(List<int> myList)
        {
            int sum = 0;
			HashSet<int> add = new HashSet<int>(myList);

			foreach (int digit in add)
			{
				sum += digit;
			}
			return (sum);
        }
    }