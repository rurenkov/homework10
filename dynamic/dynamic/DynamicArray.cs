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
       
        public DynamicArray(T[] array)
        {
            Array = array;
            capacity = array.Length;
        }
   
        public void Add(T addValue)
        {
               if(head == Array.Length)
                {
                capacity = (gFactor * capacity);
                /*looks like one more method*/
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

