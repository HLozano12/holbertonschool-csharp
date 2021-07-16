using System;
using System.Collections.Generic;

class LList
// link list
{
    public static LinkedListNode<int> Add(LinkedList<int> myLList, int n)
	// add a node to beginning of link list
    {
        LinkedListNode<int> newNode = new LinkedListNode<int>(n);
        myLList.AddFirst(newNode);
		// adds a node at the start of LL
        return (newNode);
    }
}