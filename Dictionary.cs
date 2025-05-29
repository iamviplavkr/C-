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
            Dictionaryy();
        }
        static void Dictionaryy()
        {
            Dictionary<int,string> names = new Dictionary<int,string>();

            names.Add(1, "Messi");
            names.Add(2, "Ronaldo");
            names.Add(3, "Neymar");
            names.Add(4, "Cubarsi");

            for (int i = 0; i < names.Count; i++)
            {
                KeyValuePair<int,string>pair = names.ElementAt(i);
                Console.WriteLine($"{ pair.Key} - {pair.Value}" );
            }


        }
    }
}
