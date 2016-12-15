using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dynamic
{
    public class DynamicQueue<T>
    {

        //public int tail;

        DynamicArray<T> dynamicArray = new DynamicArray<T>();

        public  void Equeue(T put)
        {

            dynamicArray.Add(put);
                            
        }


 








    }
}
