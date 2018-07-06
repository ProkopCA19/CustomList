using System;
using System.Collections.Generic;
using System.Text;

namespace CustomList
{
    public class CustomList<T>
    {
        private T[] baseArray;
        private int count;
        private int capacity;
        private int index;

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

        public int Index
        {
            get
            {
                return index;
            }
            set
            {
                index = value;
            }
        }

        public CustomList()
        {
            count = 0;
            capacity = 5;
            baseArray = new T[capacity];
        }


        public int IndexOf(T item)
        {
     
            for(int i = 0; i < 0; i++)
            {
               if( baseArray[i].Equals(item))
               {
                    index = i;
               }
            }

            return index;
        }



        public void Add(T item)
        {

            if (count >= capacity)
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
            else
            {
                baseArray[count] = item;
                count++;
            }

        }

        public void Remove(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (baseArray[i].Equals(item))
                {
                    //shift array
                    count--;
                }

            }

        }


        public void AdjustArray()
        {



        }


    }







        //public IEnumerator<T> GetEnumerator()
        //{
        //    for (int i = 0; i < myArray.Length; i++)
        //    {
        //        yield return myArray[i];
        //    }
        //}

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    throw new NotImplementedException();
        //}
    
}
