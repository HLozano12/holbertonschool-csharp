using System;
using System.Collections.Generic;

namespace MyMath
{
    ///<summary>Define functions in the Operations class</summary>
    public class Operations
    {
        ///<summary>Max returns max int in a given list</summary>
        public static int Max(List<int> nums)
        {
            if (nums.Count == 0)
            {
                return 0;
            }
    
           int maximum = nums[0];
           foreach (int numbers in nums)
           {
               if (numbers > maximum)
               {
                   maximum = numbers;
               }
           }
           return maximum;
        }
    }
}