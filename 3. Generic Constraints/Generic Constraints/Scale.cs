using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Generic_Constraints
{
    class Scale<T> where T: IComparable<T>
    {
        public T left;
        public T right;

        public Scale(T left, T right)
        {
            this.left = left;
            this.right = right;
        }

        public T GetHeavier()
        {
            if (left.CompareTo(right) == 1)
                return this.left;
            else
                return this.right;
        }
    }
}
