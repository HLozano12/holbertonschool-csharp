using System;
using System.Collections.Generic;

    class Except
    {
        public static void ThrowMsg(string msg)
		// throw exception with a msg
        {
			throw new Exception(msg);
        }
    }