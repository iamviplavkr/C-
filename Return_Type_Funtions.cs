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
            Console.WriteLine($"Name is {ReturnName()} and age is {ReturnAge()}");
        }
        static  string ReturnName()
        {
            return "Harry";
        }
        static int ReturnAge()
        {
            return 21;
        }
    }
}
