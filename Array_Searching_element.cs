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
            Console.Write("Enter the size of array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Enter the numbers : ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter the search element: ");
            int search = Convert.ToInt32(Console.ReadLine());


            int position = Array.IndexOf(numbers, search);
            if (position > 0)
            {
                Console.WriteLine($"Number {search} has been found at {position} position");

            }
            else
            {
                Console.WriteLine("Number does not exist");

            }
                Console.ReadLine();
        }
    }
}
