using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dynamic
{
    public class DynamicArray<T> : Dynamic<T>
    {
        public const int gFactor = 2;
        public int capacity = 1;
        public T addValue;
        public int size;
        public int IndexToInsert;
        public int maxSize=10;

        public DynamicArray()
        {
            Array = new T[capacity];
            //capacity = array.Length;
        }


        public override void Insert(T addValue, int IndexToInsert)
        {
            if (IndexToInsert >= size && IndexToInsert < capacity)
            {
                Console.WriteLine("index is out of size");

            }

            else if (IndexToInsert < size && IndexToInsert < capacity)
            {

                for (int i = size; i > IndexToInsert; i--)  //move  to  right
                {
                    if (size == Array.Length)       // if array is full , so add capacity
                    {
                        capacity = (gFactor * capacity);
                        copyArray(capacity);
                        Array[i] = Array[i - 1];
                    }

                    Array[i] = Array[i - 1];
                }
                Array[IndexToInsert] = addValue;                //insert 
                size++;
            }

        }


        public override void Add(T addValue)
        {
            if (size == Array.Length)
            {
                capacity = (gFactor * capacity);

                copyArray(capacity);
                Array[size] = addValue;
                size++;
            }

            else if (size < Array.Length)
            {
                Array[size] = addValue;
                size++;
            }

        }

        public override void Remove(int IndexToInsert)  // not logical name of index 
        {
            for (int i = IndexToInsert; i < (size - 1); i++)          //move elements to left
            {
                Array[i] = Array[i + 1];
            }
            size--;
            if ((capacity - size) >= size)
            {
                capacity = (capacity / gFactor);
                copyArray(capacity);

            }
        }

        public void copyArray(int capacity)
        {
            T[] tempArray;                     //add temp array
            tempArray = new T[Array.Length];
            Array.CopyTo(tempArray, 0);         //copy Array to tempArray
            Array = new T[capacity];             //New capacity for Array
            tempArray.CopyTo(Array, 0);
        }


        public override T Get(int IndexToInsert)  // not logical name of index 
        {
            return Array[IndexToInsert];
        }

        public void Print()
        {

            Console.WriteLine("[{0}]", string.Join(", ", Array));

        }







    }



}

