using System;
using System.Collections.Generic;

    class Dictionary
    {
        public static Dictionary<string, string> AddKeyValue(Dictionary<string, string> myDict, string key, string value)
        // replace if key exit
		// create if key does not exit
		// return updated dickt
		{
           myDict[key] = value;
           return (myDict);
        }
    }