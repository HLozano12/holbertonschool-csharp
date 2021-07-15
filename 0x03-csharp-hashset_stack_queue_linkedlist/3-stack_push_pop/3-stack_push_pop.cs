using System;
using System.Collections.Generic;
    class MyStack
    {
        public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
		// Using Stackstring print number of items in aStack
        {
            Console.WriteLine("Number of items: " + aStack.Count);

			if (aStack.Count ==0 )
			// if stack empty
			{
				Console.WriteLine("Stack is empty");
			}
			else
			{
				Console.WriteLine("Top item: {0}", aStack.Peek());
				// print item at top without removing
			}
			Console.WriteLine("Stack contains \"{0}\": {1}", search, aStack.Contains(search));
			if (aStack.Contains(search) == true)
			// If contains given item, remove all items
			{
				while (aStack.Pop() != search)
				{
					;
				}
			}
			aStack.Push(newItem);
			return (aStack);
        }
    }