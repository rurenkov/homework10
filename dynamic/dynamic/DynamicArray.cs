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
        public int size =0;
        public T addValue;
        public int head;
        public int free;
  //      public int put;


        public DynamicArray(T[] array)
        {
            Array = array;
            free = array.Length - size;
            capacity = array.Length;
           
        }
   
   

        //public DynamicQueue(T[] array) : base(array)
        //{
        //}

        public void Add(T addValue)
        {
            if (free >= 0)
            {
                if(size == Array.Length)
                {
                    capacity = (gFactor * capacity);
                    Array = new T[capacity];
                    Console.WriteLine("length" + Array.Length);         //debug
                    Array[head-1] = addValue;
                    
                    size++;
                    head++;

                    Console.WriteLine("free__" + free);         //debug
                    Console.WriteLine("head__" + head);         //debug
                    Console.WriteLine("size__" + size);        //debug
                    Console.WriteLine("capacity__" + capacity);         //debug
                    Console.WriteLine("[{0}]", string.Join(", ", Array));


                }

                else if (size < Array.Length)
                {
                    Array[head] = addValue;
                    size++;
                    head++;
                    Console.WriteLine("free__" + free);         //debug
                    Console.WriteLine("head__" + head);         //debug
                    Console.WriteLine("size__" + size);        //debug
                    Console.WriteLine("capacity__" + capacity);         //debug
                    Console.WriteLine("[{0}]", string.Join(", ", Array));
                }
                free--;
              
            }








        }

        public  void Print()
        {

            Console.WriteLine("[{0}]", string.Join(", ", Array));

        }







    }



}

