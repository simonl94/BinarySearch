using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // create array and output it
            BinaryArray searchArray = new BinaryArray();
            Console.WriteLine(searchArray);

            // prompt and input first int from user
            Console.Write("Please enter an integer value (-1 to quit): ");
            var searchInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // repeatedly input an integer; -1 terminates the application
            while (searchInt != -1)
            {
                // use binary search to try to find integer
                var position = searchArray.findValue(searchInt); // location of search key in array

                // return value of -1 indicates integer was not found
                if (position == -1)
                    Console.WriteLine("The integer {0} was not found.\n", searchInt);
                else
                    Console.WriteLine("The integer {0} was found in position {1}.\n", searchInt, position);

                // Get next input from user
                Console.WriteLine("Please enter an integer value (-1 to quit): ");
                searchInt = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }
        }
    }
}

