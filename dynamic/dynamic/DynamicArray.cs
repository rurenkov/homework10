using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dynamic
{
    public  class DynamicArray<T>
    {
        public T[] Array;
        public const int gFactor = 2;
        public int capacity;
        public T addValue;
        public int head;
        public int size=3;
        public int IndexToInsert;
       
        public DynamicArray(T[] array)
        {
            Array = array;
            capacity = array.Length;
        }



        public void Remove(int IndexToInsert)  // not logical name of index 
        {
            for (int i = IndexToInsert; i < (size - 1); i++)          //move all elements to the left until deleted index reached
            {
                Array[i] = Array[i + 1];
            }
            size--;
        }



        public T Get (int IndexToInsert)
        {
            return Array[IndexToInsert];
        }

    
        public void Insert(T addValue, int IndexToInsert)
        {
            if (IndexToInsert > size && IndexToInsert < capacity)
            {
                Array[IndexToInsert] = addValue;
            }


            else if (IndexToInsert<size && IndexToInsert < capacity)
            {

                for (int i = size; i >= IndexToInsert; i--)  //move  to  right
                {
                    Array[i] = Array[i - 1];
                }
                Array[IndexToInsert] = addValue;                //insert 
                size++;
            }

        }
        
        
        public void Add(T addValue)
        {
               if(head == Array.Length)
                {
                capacity = (gFactor * capacity);
             
                T[] tempArray;                     //add temp array
                tempArray = new T[Array.Length];    
                Array.CopyTo(tempArray, 0);         //copy Array to tempArray
                /******************************/
               Array = new T[capacity];             //New capacity for Array
               tempArray.CopyTo(Array, 0);          //copy temArray to Array
               Array[head] = addValue;
               head++;
        }

                else if (head < Array.Length)
                {
                    Array[head] = addValue;
                    head++;
                    //Console.WriteLine("head__" + head);         //debug
                    //Console.WriteLine("capacity__" + capacity);         //debug
                    //Console.WriteLine("[{0}]", string.Join(", ", Array));
                }
  
            }



        public  void Print()
        {

            Console.WriteLine("[{0}]", string.Join(", ", Array));

        }







    }



}

