using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dynamic
{
    public class DynamicStack<T>
    {


        DynamicArray<T> dynamicArray = new DynamicArray<T>();
        private T size;






        //*******************************************************//
        // push method;
        //*******************************************************//
        public void Push(T put)
        {

            dynamicArray.Add(put);


        }

        //*******************************************************//
        // pop method;
        //*******************************************************//
        public T Pop()
        {

            int size=dynamicArray.size - 1;

           
            dynamicArray.Remove(dynamicArray.size - 1);                  
            return this.size;

        }
        //*******************************************************/
        // peek method;
        //*******************************************************//

        public T Peek()
        {

            int size = dynamicArray.size-1;
            //size = size - 1;
            return this.size;
           

        }


        public  void Print()
        {

            Console.WriteLine("[{0}]", string.Join(", ", dynamicArray.Array));

        }


    }






    }

