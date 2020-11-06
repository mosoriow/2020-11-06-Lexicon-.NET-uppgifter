using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Array_Creator
{
    class ArrayCreator
    {
        public static T[] Create<T>(int length, T item)
        {
            List<T> result = new List<T>();

            for(int i = 0; i < length; i++)
                result.Add(item);

            return result.ToArray();
        }
    }
}
