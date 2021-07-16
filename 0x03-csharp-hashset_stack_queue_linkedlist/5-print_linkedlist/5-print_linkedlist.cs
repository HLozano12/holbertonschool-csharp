using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> myLList = new LinkedList<int>();

        for (int h = 0; h < size; h++)
        {
            myLList.AddLast(h);
            Console.WriteLine(h);
        }

        return myLList;
    }
}