using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Box_of_T
{
    // Box of elements of a generic type
    class Box<T> 
    {
        private List<T> box;

        public Box()
        {
            this.box = new List<T>();
        }

        public void Add(T element)
        {
            this.box.Add(element);
        }

        public T Remove()
        {
            T element;

            if (this.box.Count > 0)
            {
                element = this.box[this.box.Count - 1];
                this.box.RemoveAt(this.box.Count - 1);
            }
            else
            {
                throw new ArgumentException("empty box! no possible to remove any element");
            }

            return element;
        }

        public int Count
        {
            get { return this.box.Count; }
        }
    }
}
