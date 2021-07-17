using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    { 
        LinkedListNode<int> current = myLList.First;

        foreach (int numbers in myLList)
        {
            if (n < numbers)
            {
                myLList.AddBefore(current, n);
                return myLList.Find(n);
            }
            current = current.Next;
        }
        myLList.AddLast(n);
        return myLList.Last;
    }
}