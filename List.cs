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
            List<int> listnumbers = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter numbers: ");
                listnumbers.Add(Convert.ToInt32(Console.ReadLine()));
            }

            for (int i = 0; i < listnumbers.Count; i++)
            {
                Console.WriteLine(listnumbers[i]);
            }

           listnumbers.RemoveAt(0);

            foreach (int num in listnumbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
