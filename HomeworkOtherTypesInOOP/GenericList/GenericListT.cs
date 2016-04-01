using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    [Version(3, 1)]
    public class GenericListT<T>
        where T : IComparable<T>
    {
        private const uint DEFAULT_SIZE = 16;

        private T[] elements;
        private uint count = 0;

        public GenericListT(uint capacity = DEFAULT_SIZE)
        {
            if (capacity == 0)
            {
                throw new ArgumentOutOfRangeException("GenericList can not have a zero capacity!");
            }
            this.elements = new T[capacity];
        }

        public T this[uint index]
        {
            get
            {
                if (index >= this.count)
                {
                    throw new IndexOutOfRangeException(String.Format("Invalid Index: {0}", index));
                }

                T value = elements[index];
                return value;
            }
        }

        public void AddElem(T elem)
        {
            if (this.count >= this.elements.Length)
            {
                this.ResizeArray();
            }

            this.elements[this.count] = elem;
            this.count++;
        }

        public void RemoveAtIndex(uint position)
        {
            if (position >= this.count)
            {
                throw new IndexOutOfRangeException(String.Format("Invalid Index: {0}", position));
            }

            for (uint i = position; i < this.count - 1; i++)
            {
                this.elements[i] = this.elements[i + 1];
            }

            this.count--;
            this.elements[count] = default(T);
        }

        public void InsertAtIndex(uint position, T insert)
        {
            if (position >= this.count)
            {
                throw new IndexOutOfRangeException(String.Format("Invalid Index: {0}", position));
            }

            if (this.count == this.elements.Length)
            {
                this.ResizeArray();
            }

            for (uint i = count; i < position; i--)
            {
                this.elements[i] = this.elements[i - 1];
            }

            this.count++;
            this.elements[position] = insert;
        }

        public void ClearList()
        {
            this.elements = new T[this.elements.Length];
            this.count = 0;
        }

        public int IndexOf(T value)
        {
            int indexOf = -1;
            for (int i = 0; i < this.count; i++)
            {
                if (this.elements[i].Equals(value))
                {
                    indexOf = i;
                    break;
                }
            }

            return indexOf;
        }

        public bool Contains(T value)
        {
            return this.IndexOf(value) == -1 ? false : true;
        }

        public T Max()
        {
            if (this.count == 0)
            {
                throw new InvalidOperationException("The GenericList is empty");
            }

            T max = this.elements[0];

            for (int i = 1; i < this.elements.Length; i++)
            {
                if (this.elements[i].CompareTo(max) > 0)
                {
                    max = this.elements[i];
                }
            }

            return max;
        }

        public T Min()
        {
            if (this.count == 0)
            {
                throw new InvalidOperationException("The GenericList is empty");
            }

            T min = this.elements[0];

            for (int i = 1; i < this.elements.Length; i++)
            {
                if (this.elements[i].CompareTo(min) < 0)
                {
                    min = this.elements[i];
                }
            }

            return min;
        }

        private void ResizeArray()
        {
            T[] resizedArray = new T[this.elements.Length * 2];

            for (int i = 0; i < this.elements.Length; i++)
            {
                resizedArray[i] = this.elements[i];
            }

            this.elements = resizedArray;
        }

        public override string ToString()
        {
            if (this.count == 0)
            {
                return "The GenreicList is empty";
            }

            StringBuilder list = new StringBuilder();

            for (int i = 0; i < this.count; i++)
            {
                list.AppendLine(String.Format("Item {0}: {1}", i, this.elements[i]));
            }

            return list.ToString();
        }
    }
}
