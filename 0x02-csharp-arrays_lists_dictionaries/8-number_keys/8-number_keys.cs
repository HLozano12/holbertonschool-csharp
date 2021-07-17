using System;
using System.Collections.Generic;


class Dictionary
// change class per task
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
	// return the number of keys in a dict
    {
        int h = 0;
        foreach (KeyValuePair<string, string> pairs in myDict)
        {
            h++;
        }
        return h;
    }
}