using System;
using System.Collections;


namespace _12._2
{
    class MyCollection : ICollection, IList
    {
        int[] array = new int[4];
        int count = 0;
        public int Count()
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != 0)
                {
                    count++;
                }
            }
            return count;
        }
        public int Capacity()
        {
            return array.Length;
        }

        public bool IsSynchronized => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();

        public bool IsFixedSize => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        int ICollection.Count => throw new NotImplementedException();

        public object this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int Add(object element)
        {
            Boolean flag = false;
            int count = 0;
            do
            {
                for (int i = count; i < array.Length; i++)
                {
                    if (array[count] == 0)
                    {
                        array[count] = (int)element;
                        flag = true;
                        break;
                    }
                    count++;
                }
                if (flag == false)
                {
                    array = new int[count * 2];
                }
            } while (flag);
            return 1;
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(object value)
        {
            throw new NotImplementedException();
        }

        public int IndexOf(object value)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, object value)
        {
            throw new NotImplementedException();
        }

        public void Remove(object element)
        {
            int[] newAr = new int[array.Length];
            for(int i=0; i<array.Length; i++)
            {
                if(array[i] == (int)element)
                {
                    Array.Copy(array, 0, newAr, 0, i);
                    Array.Copy(array, i + 1, newAr, i, array.Length - i - 1);
                    newAr[array.Length - 1] = 0;
                }
            }
            array = newAr;
        }

        public void RemoveAt(int index)
        {
            int[] newAr = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                if (i == index)
                {
                    Array.Copy(array, 0, newAr, 0, i);
                    Array.Copy(array, i + 1, newAr, i, array.Length - i - 1);
                    newAr[array.Length - 1] = 0;
                }
            }
            array = newAr;
        }
        public void GetInfo()
        {
            for(int i=0; i<array.Length; i++)
            {
                Console.WriteLine("array[" + i + "]: " + array[i]);
            }
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
