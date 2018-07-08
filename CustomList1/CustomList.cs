using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CustomList
{
    public class CustomList<T> : IEnumerable <T>
    {
        private T[] baseArray;
        private int count;
        private int capacity;

        public int Count
        {
            get
            {
                return count;
            }
        }

        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
            }
        }
        public T this[int i]
        {
            get
            {
                return baseArray[i];
            }
            set
            {
                baseArray[i] = value;
            }
        }

      

        public CustomList()
        {
            count = 0;
            capacity = 5;
            baseArray = new T[capacity];
        }


        public void Add(T item)
        {

            if( capacity > count)
            {
                baseArray[count] = item;
                count++;
            }
            else if(count >= capacity)
            {
                capacity += 5;
                T[] newArray = new T[capacity];

               
                for (int i = 0; i < count; i++)
                {
                    newArray[i] = baseArray[i];
                }

                baseArray = newArray;
                baseArray[count] = item;
                count++;   
            }
            

        }

        public bool Remove(T item)
        {
           
            for (int i = 0; i < count; i++)
            {
                if (baseArray[i].Equals(item))
                {
                    count--;
                    AdjustArray(i);
                    return true;
                }
            }
            return false;
        }

        public void AdjustArray(int i)
        {
            T[] newArray = new T[capacity];

            for (int x = i; x < count; x++)
            {
                newArray[x] = baseArray[x + 1];
                baseArray = newArray;
            }
        }

        public override string ToString()
        {
            string myString = ", ";

            for (int i = 0; i < count; i++) 
                myString += baseArray[i];
                return myString;
        }










        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < baseArray.Length; i++)
            {
                yield return baseArray[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }


    
}
