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
            Console.Write("Enter the Password: ");
            String password = Console.ReadLine();
            if (password == null)
            {
                Console.WriteLine("Please enter a Password ");
            }
            Console.Write("Enter the Password again: ");
            String password2 = Console.ReadLine();
            if (password2 == null)
            {
                Console.WriteLine("Please enter a Password ");
            }
            if (password2 == password)
            {
                Console.WriteLine("Passwords Match ");
            }
            else
            {
                Console.WriteLine("Passwords do not match");
            }



        }
    }
}
