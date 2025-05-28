using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]
            {
                4,5,33,4,55,6,1,7,77
            };

            Array.Sort(numbers);

            foreach (int num in numbers)
            {
                Console.Write($"{num} ");
                
            }
            Console.ReadLine();



        }
    }
}
