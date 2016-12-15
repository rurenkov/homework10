using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dynamic
{
    class Program
    {
        public static void ParceD(ref int d)
        {
            while (!int.TryParse(Console.ReadLine(), out d))
            {
                Console.WriteLine("Try again..");
            }
        }

        static void Main(string[] args)
        {
            int choise = 0;  //some internal 
            int free1 = 1;  //some internal     

            int addValue = 0;
            int  capacity = 1;
            int IndexToInsert = 0;
            int[] array1;

            //Console.WriteLine("Enter the capacity of array \n");
            //ParceD(ref capacity);                     //parce value which needs to be added
            array1 = new int[capacity];
            DynamicArray<int> dynamicArray = new DynamicArray<int>();

            while (free1 > 0)
            {
                Console.WriteLine("To add value press :1, to insert :2, to exit press: 3 \n");

                ParceD(ref choise);
                switch (choise)
                {
                    case 1:
                
                        Console.WriteLine("Enter what you want to add \n");
                        ParceD( ref addValue);                     //parce value which needs to be added
                        dynamicArray.Add(addValue);
                        dynamicArray.Print();

                        break;

                    case 2:

                        Console.WriteLine("Enter what you want to Insert \n");
                        ParceD(ref addValue);
                        Console.WriteLine("Enter # of Index to insert \n");
                        ParceD(ref IndexToInsert);
                        dynamicArray.Insert(addValue,IndexToInsert);
                        dynamicArray.Print();
                        break;
                    case 3:

                        {
                            free1 = 0;
                            
                        }
                        break;
                }
            }

            Console.ReadLine();

          

        }

    }













}

