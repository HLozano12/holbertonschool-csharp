using System;
using System.Collections.Generic;
    class MyQueue
    {
        public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
        {
            Console.WriteLine("Number of items: {0}", aQueue.Count);
			// Print number in aQueue

			if (aQueue.Count == 0 || aQueue == null)
				// if queue is empty
			{
				Console.WriteLine("Queue is empty");
			}
			else
        	{
            	Console.WriteLine("First item: {0}", aQueue.Peek());
        	}

        	aQueue.Enqueue(newItem);

        	Console.WriteLine("Queue contains \"{0}\": {1}", search, aQueue.Contains(search));

        	if (aQueue.Contains(search))
        	{
            	while (aQueue.Count > 0)
            	{
                	string value = aQueue.Dequeue();
                	if (value == search)
                	{
                    	break;
                	}
            	}
        	}

        	return aQueue;
        }
    }