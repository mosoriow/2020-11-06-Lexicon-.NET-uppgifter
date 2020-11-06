using System;
using System.Collections.Generic;
using System.Linq;

namespace Generic_Constraints
{
    class Program
    {
        static void Main(string[] args)
        {
            Scale<int> test = new Scale<int>(5,5);

            Console.WriteLine(test.GetHeavier());
        }
    }
}
