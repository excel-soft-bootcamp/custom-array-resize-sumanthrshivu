using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayUtilityProgram
{
    public  class ArrayUtility
    {
        public static void Resize(ref int[] array, int newSize)
        {
                int[] tempArray = new int[newSize];

                for (int i = 0; i < array.Length; i++)
                {
                    tempArray[i] = array[i];

                }
                array = tempArray;
        }
    }
    
}
