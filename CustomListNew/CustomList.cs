using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>:IEnumerable<T>
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

            if (capacity > count)
            {
                baseArray[count] = item;
                count++;
            }
            else if (count >= capacity)
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

            for (int x = i; x < count; x++)
            {
                baseArray[x] = baseArray[x + 1];
            }
        }

        public override string ToString()
        {
            string newString = "";

            newString = baseArray[0].ToString();
            for (int i = 1; i < count; i++)
            {
                newString = newString + " " + baseArray[i].ToString();
            }

            return newString;

        }


        public static CustomList<T> operator +(CustomList<T> firstList, CustomList<T> secondList)
        {
            CustomList<T> thirdList = firstList;
            if (firstList != null && secondList != null)
            {
                for (int i = 0; i < secondList.count; i++)
                {
                    thirdList.Add(secondList[i]);
                }
            }
            return thirdList;
        }


        public static CustomList<T> operator -(CustomList<T> firstList, CustomList<T> secondList)
        {
            if (firstList !=null && secondList !=null)
            {
                for(int i = 0; i < firstList.count; i++)
                {
                    for( int x =0; x < secondList.count; x++)
                    {
                        if (secondList[x].Equals(firstList[i]))
                        {
                            firstList.Remove(firstList[i]);

                        }
                    }
                }
        
            }
            return firstList;
        }



        public CustomList<T> Zip(CustomList<T> listToZip)
        {
            CustomList<T> zippedList = new CustomList<T>();

            if (Count > listToZip.Count)
            {
                for (int i = 0; i < Count; i++)
                {
                    zippedList.Add(baseArray[i]);
                    if (i < listToZip.Count)
                    {
                        zippedList.Add(listToZip[i]);
                    }
                }
                return zippedList;
            }
            else if (Count < listToZip.Count)
            {
                for (int i = 0; i < listToZip.Count; i++)
                {
                    if (i < Count)
                    {
                        zippedList.Add(baseArray[i]);
                    }
                    zippedList.Add(listToZip[i]);
                }
                return zippedList;
            }
            else if (Count == listToZip.Count)
            {
                for (int i = 0; i < Count; i++)
                {
                    zippedList.Add(baseArray[i]);
                    zippedList.Add(listToZip[i]);
                }
                return zippedList;
            }
            return zippedList;
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





        

