//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace dynamic
//{
//    public  class DynamicStack<T>: DynamicArray<T>
//    {

        
//          public int top;

//        public DynamicStack(T[] array) : base(array)
//        {
//        }

       
//            public override bool IsEmpty()
//            {

//                if (top == 0)
//                {
//                    Console.WriteLine("stack is empty");

//                }
//                return true;
//            }
//            //*******************************************************//
//            // is FULL  stack;
//            //*******************************************************//

//            public override bool IsFull()
//            {

//                if (top > Array.Length)
//                {
//                    Console.WriteLine("Stack is full");
//                }
//                return true;
//            }



//            //*******************************************************//
//            // push method;
//            //*******************************************************//
//            public void Push(T put)
//            {

//                if (top != Array.Length)
//                {
//                    Console.WriteLine("PUT_ " + put);         //debug
//                    Array[top] = put;
//                    top++;
//                    Console.WriteLine("array top_ " + Array[top]);         //debug
//                }
//                Console.WriteLine("top_push_" + top);         //debug


//            }

//            //*******************************************************//
//            // pop method;
//            //*******************************************************//
//            public T Pop()
//            {

//                if (top > 0)
//                {
//                    Array[top - 1] = Array[0];
//                    top--;
//                }

//                Console.WriteLine("top_pop_" + top);
//                return Array[top];

//            }
//            //*******************************************************//
//            // peek method;
//            //*******************************************************//

//            public T Peek()
//            {


//                return Array[top - 1];

//            }


//            public override void Print()
//            {

//                Console.WriteLine("[{0}]", string.Join(", ", Array));

//            }


//        }*/






//    }
//}
