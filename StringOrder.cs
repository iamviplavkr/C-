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
            Console.Write("Enter your message: ");
            string message = Console.ReadLine();
            for (int i = 0; i < message.Length; i++)
            {
                Console.WriteLine(message[i]);
            }
        }
    }
}
