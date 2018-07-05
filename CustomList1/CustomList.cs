using System;
using System.Collections.Generic;
using System.Text;

namespace CustomList
{
    public class CustomList<T>
    {
        private T[] myArray;
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
                return myArray[i];
            }
            set
            {
                myArray[i] = value;
            }
        }


        public CustomList()
        {
            count = 0;
            capacity = 4;
            myArray = new T[capacity];
        }



        public void Add(T item)
        {

            if (count >= capacity)
            {
                capacity += 4;
                T[] newArray = new T[capacity];

               
                for (int i = 0; i < count; i++)
                {
                    newArray[i] = myArray[i];
                }

                myArray = newArray;
                myArray[count] = item;
                count++;   
            }
            else
            {
                myArray[count] = item;
                count++;
            }

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
