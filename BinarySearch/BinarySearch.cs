using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class BinaryArray
    {
        public int[] array; //array of values
        public static Random randNum = new Random();

        public BinaryArray()
        {
            array = new int[10]; //array length

            // fill array with random numbers
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randNum.Next(0, 100);
            }

            Array.Sort(array);
        }


        public int findValue(int searchElement)
        {
            int lower = 0;
            int upper = array.Length - 1;
            int value = -1;
            int middle = (lower + upper - 1) / 2;

            do
            {
                // Print remaining elements in an array
                Console.WriteLine(RemainingElements(lower, upper));
         
                for (int i = 0; i < middle; i++)
                    Console.WriteLine("  ");
                   
                Console.WriteLine(" * "); //Shows current middle
                
                //If the element is found at middle
                if (searchElement == array[middle])
                    value = middle;

                else if (searchElement < array[middle])
                {
                    value = middle - 1; //Elminates lower half
                }
                else
                {
                    lower = middle + 1; //Elminates lower half

                    middle = (lower + upper + 1) / 2; //Re-calculates middle
                }
            } while ((lower <= upper) && (value == -1));

            return value;
            
        }

        public string RemainingElements(int lower, int upper)
        {
            string temporary = string.Empty;

            // output spaces for alignment
            for (int i = 0; i < lower; i++)
                temporary += "    ";

            // output elements left in array 
            for (int i = lower; i <= upper; i++)
                temporary += array[i] + " ";

            temporary += "\n";
            return temporary;
        }

        public override string ToString()
        {
            return RemainingElements(0, array.Length - 1);
        }
    }
}
