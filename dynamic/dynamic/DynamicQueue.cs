//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace dynamic
//{
//    public class DynamicQueue<T> : DynamicArray<T>
//    {

//        public int tail;

//        public DynamicQueue(T[] array) : base(array)
//        {
//        }

//        public void Add(T addValue)
//        {
//            if (free > 0)
//            {
//                if (head < Array.Length)
//                {
//                    Array[head] = addValue;
//                    head++;
//                    size++;
//                }
//                else if (head == Array.Length)
//                {
//                    head = 0;
//                    Array[head] = addValue;
//                    head++;
//                }
//                free--;
//                Console.WriteLine("free__" + free);         //debug
//                Console.WriteLine("tail__" + tail);         //debug
//                Console.WriteLine("size__" + size);         //debug
//            }








//        }

//        public override void Print()
//        {

//            Console.WriteLine("[{0}]", string.Join(", ", Array));

//        }
//    }
//}
