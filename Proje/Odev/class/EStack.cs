using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev
{
    
    public class EStack<T> : IEnumerable<T>
    {
        private T[] data;
        public int size;

        public EStack(int size)
        {
            data = new T[size];
        }

        public EStack() : this(1000)
        {
        }

        public void Push(T item)
        {
            if (size == data.Length)
            {
                throw new InvalidOperationException("Stack boş.");
            }

            data[size++] = item;
        }

        public T Pop()
        {
            if (size == 0)
            {
                throw new InvalidOperationException("Stack boş.");
            }

            return data[--size];
        }

        public T Peak()
        {
            if (size == 0)
            {
                throw new InvalidOperationException("Stack boşaldı.");
            }

            return data[size - 1];
        }

        public int Size()
        {
            return size;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = size - 1; i >= 0; i--)
            {
                yield return data[i];
            }
        }

      
     
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}