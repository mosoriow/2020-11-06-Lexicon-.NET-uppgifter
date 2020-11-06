using System;

namespace Generic_Array_Creator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = ArrayCreator.Create(5, "Peter");
            int[] integers = ArrayCreator.Create(10, 33);

            for(int i=0; i < strings.Length; i++)
                Console.WriteLine($"{i}: {strings[i]}");

            for (int i=0; i < integers.Length; i++)
                Console.WriteLine($"{i}: {integers[i]}");
        }
    }
}
