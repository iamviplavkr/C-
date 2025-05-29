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
            WelcomeMessage();
            CreateAndPrintArray();


        }
        static void CreateAndPrintArray()
        {
            int[] numbers = new int[5] { 1, 2, 3, 4, 5 };
            foreach (var items in numbers) {
                Console.Write($"{items} ");
            }
        }
        static void  WelcomeMessage()
        {
            Console.WriteLine("Welcome to the Program!");

        }
    }
}
